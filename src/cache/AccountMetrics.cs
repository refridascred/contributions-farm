using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the githubfarm route series from a seed.</summary>
        public static long SeriesGithubfarmRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                long slot = 1;
                if ((step / 2) > (step & 3))
                {
                    slot = slot - ((long)i * 3);
                    sum = ((sum * 2) + slot) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of counter profile readings.</summary>
        public static long PairCounterProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double ratio, double floor)
        {
            double ratio2 = (ratio * 11.0) / 7.0;
            for (int i = 0; i < 2; i++)
            {
                ratio2 = ((ratio2 + (ratio * 3.2)) + (double)(long)i) - floor;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
