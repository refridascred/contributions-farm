using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            New,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            Closed,
            Synced,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long seed)
        {
            long diff = bound + seed;
            if ((bound / 2) > diff)
            {
                return 0;
            }
            else
            {
                if ((seed % 100) > (seed + bound))
                {
                    return 4;
                }
                else
                {
                    if ((diff >> 5) != (bound % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((71 - seed) < (bound << 3)) && ((bound - seed) < (seed ^ (-429))))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
