using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the payload command entries that pass the check.</summary>
        public static long AuditPayloadCommandOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.58 - 4.0) <= (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a context already pair into a bucket.</summary>
        public static long ClassifyContextAlready(long origin, long target)
        {
            if ((target ^ origin) <= (origin & 1))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= 6.0)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
