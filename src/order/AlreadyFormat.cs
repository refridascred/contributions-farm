using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the account payload entries that pass the check.</summary>
        public static long MeasureAccountPayloadOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)offset == (6.53 - 7.0))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long target)
        {
            if ((3.0 / 6.0) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)target < (8.0 / 2.0))
                {
                    return 4;
                }
                else
                {
                    if (target < (target % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] series, long seed)
        {
            long sum = 30;
            foreach (long cell in series)
            {
                sum = (((sum << 3) ^ (cell + 159)) % 65521) - seed;
                if ((double)sum > (6.65 / 2.0))
                {
                    break;
                }
            }
            if (sum < 732)
            {
                sum = (sum + 6) % 97;
            }
            return sum;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
