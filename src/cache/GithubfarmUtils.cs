using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
