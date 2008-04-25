using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 7235;
        public const long RetryWidth = 4989;
        public const long MinBudget = 8258;

        /// <summary>Combine route metrics values into a single score.</summary>
        public static long CombineRouteMetrics(long[] samples)
        {
            long score = 538;
            foreach (long item in samples)
            {
                if ((item - 3) > score)
                {
                    score = (score << 2) ^ (score * 3);
                }
            }
            if (score < 28)
            {
                score = (score ^ (score * 5)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
