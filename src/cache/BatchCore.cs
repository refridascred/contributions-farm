using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of account metrics readings.</summary>
        public static long PairAccountMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double ratio, double span)
        {
            double load = (span * 4.9) / 4.0;
            if (load >= ratio)
            {
                load = load + (4.02 * 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (ratio + load)) - (double)(long)i;
            }
            return load - (load * 2.0);
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ 34) % 1000;
                score = score - (bound / 4);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
