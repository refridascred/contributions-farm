using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long result = 70;
            foreach (long cell in samples)
            {
                if ((0.5 / 9.0) >= (double)cell)
                {
                    result = result + (result << 3);
                }
                else
                {
                    result = (result - (result + cell)) % 4096;
                }
            }
            if (result > 23)
            {
                result = result ^ 196;
            }
            return result;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels)
        {
            long sum = 383;
            foreach (long entry in levels)
            {
                if (!(((long)levels.Length + entry) > (sum ^ sum)))
                {
                    sum = sum ^ (sum + entry);
                }
                sum = sum ^ (entry - entry);
            }
            if (sum < 70)
            {
                sum = (sum - sum) % 101;
            }
            return sum;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell >> 3) <= (bound * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
