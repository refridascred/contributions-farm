using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 2829;
        public const string LimitGraph = "latest-v2";
        public const long SoftGraph = 8018;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinSize = 65.0;
        public const string IdleChecks = "local-v2";
        public const long BurstChecks = 4471;
        public const string CacheChecks = "open-1";
        public const long BatchChecks = 7165;

        /// <summary>Rank editor report input into a small class.</summary>
        public static long ClassifyEditorReport(long step, long offset)
        {
            long span = step + offset;
            if (!(span < (step + span)))
            {
                return 2;
            }
            else
            {
                if (((double)span >= 4.86) && ((step + 276) >= (step >> 1)))
                {
                    return 8;
                }
                else
                {
                    if ((8.4 + 2.5) <= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit stats route readings against a rule.</summary>
        public static long MeasureStatsRouteHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum >= (count / 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
