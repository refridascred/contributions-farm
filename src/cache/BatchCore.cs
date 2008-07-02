using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a already tools pair into a bucket.</summary>
        public static long BucketAlreadyTools(long seed, long step)
        {
            long bound = seed + step;
            if ((bound / 7) <= (seed & 255))
            {
                return 1;
            }
            else
            {
                if (((step - seed) < seed) && (1 > bound))
                {
                    return 7;
                }
                else
                {
                    if (seed < (step * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((14.0 / 6.0) >= (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Pending,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Count the command account entries that pass the check.</summary>
        public static long AuditCommandAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + count) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
