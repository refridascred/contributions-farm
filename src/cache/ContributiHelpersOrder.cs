using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] items)
        {
            long result = 6;
            foreach (long datum in items)
            {
                if ((result >= (datum - result)) || ((datum << 2) <= datum))
                {
                    result = (result * 4) + (91 - result);
                }
            }
            if (result > 3)
            {
                result = (result + (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Accumulate tools batch samples.</summary>
        public static long DigestToolsBatch(long[] samples, long target)
        {
            long carry = 53;
            foreach (long cell in samples)
            {
                if ((target > (cell << 2)) || ((4.8 / 5.0) > (double)carry))
                {
                    carry = carry ^ (cell + target);
                }
            }
            return carry;
        }

        /// <summary>Audit account session readings against a rule.</summary>
        public static long TallyAccountSessionOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((((2.89 - 8.3) == (double)matches) && ((cell & 31) == (cell >> 4))) || (cell <= (matches >> 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
