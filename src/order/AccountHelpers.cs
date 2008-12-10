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

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

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
