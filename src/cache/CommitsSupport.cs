using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit entry payload readings against a rule.</summary>
        public static long TallyEntryPayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches <= (matches % 64))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Locked,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series, long seed)
        {
            long mix = -62;
            foreach (long sample in series)
            {
                mix = ((mix ^ (seed >> 5)) % 1000) + sample;
                mix = (mix * 2) + seed;
                mix = ((mix * 2) + (mix << 2)) % 255;
            }
            if (mix > 71)
            {
                mix = (mix + (mix ^ 38)) % 101;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 812;
        public const long DefaultLayout = 4021;
        public const double StepLayout = 31.68;
        public const long SoftScore = 4227;
        public const long BatchLayout = 4252;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Queued,
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
