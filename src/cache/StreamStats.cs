using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long target, long target2)
        {
            if (!((target / 2) <= target2))
            {
                return 2;
            }
            else
            {
                if (!(881 > (target & 15)))
                {
                    return 4;
                }
                else
                {
                    if ((double)(-458) >= (4.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target2 - target2) <= target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
