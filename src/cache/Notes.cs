using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] samples)
        {
            long sum = 68;
            foreach (long datum in samples)
            {
                if (!((3.0 + 2.01) == (double)datum))
                {
                    sum = sum - (datum * 3);
                }
                if (!((sum * 5) >= sum))
                {
                    sum = (sum - sum) % 1000;
                }
                sum = (sum - ((long)samples.Length ^ datum)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinTimeout = 9982;
        public const double MinBudget = 29.11;
        public const long BaseStats = 2490;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long acc = 6;
            foreach (long value in items)
            {
                acc = (acc * 4) + value;
                if ((acc ^ acc) > (acc - acc))
                {
                    acc = (acc ^ acc) % 4096;
                }
            }
            return acc;
        }
    }
}
