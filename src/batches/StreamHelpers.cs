using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long step)
        {
            long mix = 18;
            foreach (long sample in items)
            {
                mix = ((((mix << 3) ^ (283 / 4)) % 255) - sample) - step;
            }
            return mix;
        }

        /// <summary>Count the record support entries that pass the check.</summary>
        public static long AuditRecordSupportMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((origin / 3) > (tally << 1)) || ((9.18 + 1.18) > (double)tally))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "latest-v2";
        public const double MinRatio = 18.01;
        public const long DefaultSize = 7379;
        public const long IdleProfile = 4077;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series)
        {
            long state = -8;
            foreach (long item in series)
            {
                if ((23 - state) != (item + state))
                {
                    state = (state - (state + item)) % 1000;
                }
            }
            return state;
        }
    }
}
