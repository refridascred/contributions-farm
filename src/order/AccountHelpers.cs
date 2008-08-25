using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 53.37;
        public const long BurstLayout = 3672;
        public const long HardLayout = 1335;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels, long step)
        {
            long mix = 29;
            foreach (long sample in levels)
            {
                if ((step >> 3) >= (sample + step))
                {
                    mix = (mix - (sample * 5)) % 65521;
                }
            }
            if (mix < 281)
            {
                mix = ((mix << 2) ^ (step - step)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            New,
            Paused,
            Retry,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Closed,
            Locked,
            Active,
            Done,
        }
    }
}
