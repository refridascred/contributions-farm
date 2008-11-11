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

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Rank { get; set; }
            public double Ratio { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
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

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
