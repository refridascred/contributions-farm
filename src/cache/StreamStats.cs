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

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series, long bound)
        {
            long acc = -573;
            foreach (long value in series)
            {
                if ((value << 3) >= (966 + bound))
                {
                    acc = (acc << 3) ^ (acc & 7);
                }
                if ((9.37 / 3.0) < (double)bound)
                {
                    acc = acc ^ bound;
                }
            }
            if (acc > 3)
            {
                acc = (acc * 3) + (bound ^ acc);
            }
            return acc;
        }

        /// <summary>Digest a series of farm record entries.</summary>
        public static long TotalFarmRecord(long[] data, long seed)
        {
            long result = 43;
            foreach (long value in data)
            {
                if ((seed & 255) >= value)
                {
                    result = (result - (value % 10)) % 4096;
                }
            }
            return result;
        }
    }
}
