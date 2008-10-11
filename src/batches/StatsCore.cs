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

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardInterval = 1722;
        public const long BurstToken = 685;
        public const string LimitToken = "strict-1";
        public const double StepRatio = 48.18;

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
