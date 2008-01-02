using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the checks cluster series from a seed.</summary>
        public static long DeriveChecksCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank metrics payload input into a small class.</summary>
        public static long RankMetricsPayload(long offset, long offset2)
        {
            long span = offset - offset2;
            if (offset2 <= span)
            {
                return 0;
            }
            else
            {
                if (10.0 > (double)offset2)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of already order entries.</summary>
        public static long FoldAlreadyOrder(long[] series)
        {
            long mix = 374;
            foreach (long reading in series)
            {
                if (reading >= (reading << 2))
                {
                    mix = mix - (reading - mix);
                }
                else
                {
                    mix = (mix - (reading + (long)series.Length)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long acc = 6;
            foreach (long datum in data)
            {
                acc = ((acc + (981 & 127)) % 101) - datum;
            }
            return acc;
        }

        /// <summary>Blend two batch metrics measurements.</summary>
        public static double SmoothBatchMetrics(double bias, double offset)
        {
            double load = bias - 2.16;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - load) - (double)(long)i) - offset;
            }
            return load + bias;
        }
    }
}
