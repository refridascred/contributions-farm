using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 3) ^ ((long)i / 3);
                if ((((long)i << 1) <= (limit + anchor)) || ((limit + 885) < (limit ^ anchor)))
                {
                    anchor = anchor ^ ((-849) - limit);
                    continue;
                }
                else
                {
                    anchor = anchor - anchor;
                }
                anchor = (anchor - (anchor * 3)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double rate, double span)
        {
            double drift = (double)47 / 8.0;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (span * 2.77)) + (double)(long)i) - rate;
            }
            return drift + 8.71;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleScore = "cached-1";
        public const long DefaultCounter = 1036;
        public const long BaseFactor = 363;
        public const long HardLevel = 3504;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double weight, double span)
        {
            double mean = span;
            return mean + weight;
        }
    }
}
