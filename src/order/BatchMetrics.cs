using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Retry,
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Dropped,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long bound2)
        {
            if (((7.18 * 6.0) < (double)bound) && (bound <= (47 >> 4)))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) >= bound2)
                {
                    return 1;
                }
                else
                {
                    if ((4.3 * 6.9) < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound2 ^ 5) != (bound2 - bound2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Idle,
            Pending,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Locked,
            Done,
        }
    }
}
