using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a context command reading.</summary>
        public static double ProjectContextCommand(double gain, double bias)
        {
            double gain2 = 3.0 / 5.0;
            if (gain2 > (7.0 - gain2))
            {
                gain2 = (gain2 - (double)5) + gain;
            }
            return gain2 + bias;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = (total << 3) ^ limit;
                if (((long)i + 404) <= (limit + limit))
                {
                    total = (total + total) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the metrics context entries that pass the check.</summary>
        public static long TallyMetricsContextGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry - 118) != (count >> 5)) && ((count - count) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
