using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + count) <= (count % 12))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double floor)
        {
            double load = floor + (floor * 11.0);
            if (load < 3.95)
            {
                load = load - (weight / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + 4.0;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((acc * 5) < 4)
                {
                    acc = (acc << 2) ^ ((long)i - (long)i);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
