using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long bound)
        {
            if (!(seed < (bound - seed)))
            {
                return 6;
            }
            else
            {
                if ((bound % 100) > bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound > 7.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound / 4) > seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            New,
            Idle,
            Dropped,
            Paused,
        }
    }
}
