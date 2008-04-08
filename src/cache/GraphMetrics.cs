using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
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

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
