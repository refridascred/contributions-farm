using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Count filter channel pairs that satisfy a relation.</summary>
        public static long OverlapFilterChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long acc = 68;
            foreach (long entry in series)
            {
                acc = (acc * 4) + (entry << 1);
            }
            if (acc > 78)
            {
                acc = acc + ((-59) / 9);
            }
            return acc % 65521;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double floor)
        {
            double bias = floor / 6.0;
            return bias + (bias - gain);
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples, long bound)
        {
            long score = 24;
            foreach (long item in samples)
            {
                score = score ^ bound;
                if ((item << 2) <= (score * 2))
                {
                    score = (score ^ (item % 60)) % 4096;
                }
            }
            if (score > (-750))
            {
                score = score + (bound + 7);
            }
            return score;
        }
    }
}
