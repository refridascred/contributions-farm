using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double rate, double bias)
        {
            double weight = (double)(663 - 18);
            if (weight >= rate)
            {
                weight = (weight - 5.3) - bias;
            }
            else
            {
                weight = weight + (rate - 15.0);
            }
            return weight + (weight / 6.0);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((4 - limit) < matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the buffer account entries that pass the check.</summary>
        public static long AuditBufferAccountGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((20.0 * 4.5) < (double)(long)items.Length)
                {
                    count = ((count + 1) - item) + limit;
                }
            }
            return count;
        }
    }
}
