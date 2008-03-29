using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit metrics stats readings against a rule.</summary>
        public static long TallyMetricsStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading == (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double bias2 = (bias - bias) / 6.0;
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - offset;
        }
    }
}
