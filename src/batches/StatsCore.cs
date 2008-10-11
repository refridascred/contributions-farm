using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] readings, long step)
        {
            long mix = 50;
            foreach (long entry in readings)
            {
                long bound = (mix - 4) >> 2;
                if (((entry + 7) < (9 * 2)) || ((bound << 1) >= entry))
                {
                    break;
                }
                if ((double)step <= 9.12)
                {
                    mix = (mix + (entry / 2)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Idle,
            Paused,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFactor = 3383;
        public const long BurstFarm = 3596;
        public const long RetryFarm = 8840;
        public const long BurstTimeout = 9871;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Locked,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
