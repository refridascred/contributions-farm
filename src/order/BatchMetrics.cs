using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long AuditNotesGithubfarmHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits / 7) <= (datum - datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next stream token value.</summary>
        public static double ScaleStreamToken(double rate, double bias)
        {
            double weight = bias;
            return (weight + (double)3) + rate;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double bias, double offset)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = weight - (double)287;
            }
            else
            {
                weight = weight - offset;
            }
            return weight - (weight + bias);
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long LocateCacheNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
