using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many route record samples are out of range.</summary>
        public static long MeasureRouteRecordGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)seed == (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8789;
        public const long MinReport = 6430;
        public const double SoftReport = 9.95;
        public const long StepSize = 5250;
        public const double HardLevel = 1.8;

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + total) % 101;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
