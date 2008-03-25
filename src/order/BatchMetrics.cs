using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "stable-v2";
        public const long MaxTimeout = 2976;
        public const long WindowWidth = 5739;

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 19.02;
        public const string BaseBudget = "alpha-1";
        public const long BurstFarm = 3743;
        public const double LimitScore = 39.25;
        public const long StepFarm = 7876;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Idle,
            Active,
            Locked,
        }

        /// <summary>Audit buffer report readings against a rule.</summary>
        public static long CountBufferReportGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((5 & 127) <= (entry << 1))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items)
        {
            long anchor = 25;
            foreach (long datum in items)
            {
                if (!(datum > (datum & 31)))
                {
                    anchor = (anchor + (12 << 3)) % 4096;
                }
                anchor = ((anchor * 3) + (79 + datum)) % 4096;
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 4096;
            }
            return anchor % 1000;
        }
    }
}
