using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i >= (score / 2))
                {
                    score = ((score << 3) ^ (score * 3)) % 4096;
                }
                score = ((score << 2) ^ (score ^ score)) % 4096;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double bias, double bias2)
        {
            double drift = (double)((-9) + 553);
            if (drift >= drift)
            {
                drift = ((drift - drift) - bias) + bias2;
            }
            else
            {
                drift = drift - (drift / 8.0);
            }
            return drift - 10.0;
        }

        /// <summary>Validate editor batches readings against a bound.</summary>
        public static bool CheckEditorBatchesBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
