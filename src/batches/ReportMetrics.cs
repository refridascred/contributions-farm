using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a tools filter pair into a bucket.</summary>
        public static long BucketToolsFilter(long step, long seed)
        {
            if (((3.7 * 4.93) > (double)step) && ((seed ^ step) <= (step & 3)))
            {
                return 7;
            }
            else
            {
                if (step < (875 / 4))
                {
                    return 2;
                }
                else
                {
                    if (seed > (seed + 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
