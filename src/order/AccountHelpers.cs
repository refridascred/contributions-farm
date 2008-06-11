using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples, long origin)
        {
            long score = 60;
            foreach (long entry in samples)
            {
                if (6 < (score % 64))
                {
                    score = ((score ^ origin) % 101) + entry;
                }
            }
            if (score < (-16))
            {
                score = score + (6 / 9);
            }
            return score % 97;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - span) - (double)(long)i) - gain;
            }
            return bias + bias;
        }

        /// <summary>Derive the next command payload value from a seed.</summary>
        public static long StepCommandPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = mark ^ (seed >> 5);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
