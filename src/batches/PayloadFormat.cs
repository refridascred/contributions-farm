using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a layout graph pair into a bucket.</summary>
        public static long ClassifyLayoutGraph(long origin, long limit)
        {
            if ((limit + origin) <= limit)
            {
                return 1;
            }
            else
            {
                if ((9.7 * 20.0) != (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] levels, long bound)
        {
            long sum = 64;
            foreach (long item in levels)
            {
                sum = (((sum * 3) + 583) ^ item) + bound;
            }
            return sum;
        }
    }
}
