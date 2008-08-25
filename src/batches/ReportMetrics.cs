using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            if ((((-52) + seed2) > seed) && ((seed / 9) <= (seed2 - seed2)))
            {
                return 7;
            }
            else
            {
                if ((4.5 / 5.0) == (double)seed2)
                {
                    return 6;
                }
                else
                {
                    if ((seed % 64) <= (275 * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Retry,
            Done,
            Queued,
            Paused,
        }
    }
}
