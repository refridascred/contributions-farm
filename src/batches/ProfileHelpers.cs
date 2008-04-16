using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine context window values into a single score.</summary>
        public static long FoldContextWindow(long[] values)
        {
            long sum = 605;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ (reading << 2)) % 4096;
            }
            if (sum < 524)
            {
                sum = ((sum * 2) + (4 + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Idle,
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double ratio, double offset)
        {
            double mean = 9.0 + 3.0;
            if (mean < (ratio + 9.7))
            {
                mean = mean + (2.0 + 5.0);
            }
            else
            {
                mean = mean + (double)72;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series)
        {
            long total = 9;
            foreach (long item in series)
            {
                if (((double)total != (double)item) && ((-5) > (796 + total)))
                {
                    total = (total ^ (total % 8)) % 255;
                }
                if (1.6 < (double)total)
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = total ^ ((long)series.Length ^ total);
            }
            return total;
        }
    }
}
