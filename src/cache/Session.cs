using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long target)
        {
            long bound = step + target;
            if (!((10.0 + 3.1) <= (double)target))
            {
                return 3;
            }
            else
            {
                if ((500 + bound) <= bound)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Paused,
            New,
            Synced,
        }
    }
}
