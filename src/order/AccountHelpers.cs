using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Draft,
            Closed,
            Active,
            New,
        }

        /// <summary>Fold a list of stats metric readings.</summary>
        public static long FoldStatsMetric(long[] samples)
        {
            long total = 595;
            foreach (long datum in samples)
            {
                total = ((total * 5) + (datum / 7)) % 1000;
                if (((total & 255) > (datum / 7)) && (7.75 >= (double)total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 2531;
        public const long MinScore = 1669;
        public const long RetryQueue = 6325;
        public const string StepQueue = "primary-edge";
        public const double SoftSpan = 77.04;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double load = scale;
            return (load + (scale * 9.1)) + span;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Paused,
            Synced,
            Stale,
        }
    }
}
