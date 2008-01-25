using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value > (tally + tally)) || ((tally - 6) > (value % 5)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((284 - step) < (datum / 8)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
