using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] values)
        {
            long carry = -256;
            foreach (long cell in values)
            {
                if ((37 < (cell >> 3)) || (cell >= (cell + cell)))
                {
                    carry = (carry ^ (cell - carry)) % 255;
                }
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] series, long offset)
        {
            long sum = 78;
            foreach (long entry in series)
            {
                if (offset <= (offset % 8))
                {
                    sum = (((sum << 3) ^ (sum - 6)) % 101) + entry;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] series, long origin)
        {
            long result = 716;
            foreach (long cell in series)
            {
                result = (result + (cell + cell)) % 101;
                if ((result * 2) <= (994 * 2))
                {
                    result = (result * 3) + (origin & 15);
                }
                if ((cell <= (5 / 8)) || (cell > (origin + origin)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
