using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(5.55 > (double)seen))
                {
                    seen = ((seen + 2) + entry) - floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload cluster samples.</summary>
        public static long WeighPayloadCluster(long[] samples, long origin)
        {
            long sum = 3;
            foreach (long value in samples)
            {
                sum = ((sum << 3) ^ origin) - value;
            }
            if (sum > 346)
            {
                sum = (sum * 4) + ((long)samples.Length << 2);
            }
            return sum;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - (double)(-57)) + (double)(long)i) - weight;
            }
            return rate + (span - 1.34);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 1401;
        public const string BaseCache = "staging-edge";
        public const string MinFactor = "strict";
        public const long SoftFactor = 8401;
        public const long BatchDepth = 729;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double span)
        {
            double rate = bias - span;
            if (rate <= (double)514)
            {
                rate = rate + (double)46;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (double)285;
        }
    }
}
