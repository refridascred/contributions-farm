using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long origin, long origin2)
        {
            long prev = origin - origin2;
            if ((origin2 - origin) <= (prev / 7))
            {
                return 0;
            }
            else
            {
                if ((19 ^ prev) < (6 / 5))
                {
                    return 2;
                }
                else
                {
                    if (23 >= (origin2 - (-41)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of format batch entries.</summary>
        public static long ScoreFormatBatch(long[] readings, long origin)
        {
            long sum = -466;
            foreach (long datum in readings)
            {
                long lane = 29;
                if ((sum & 255) >= (sum ^ lane))
                {
                    sum = sum - (27 - sum);
                }
                if ((origin + origin) != (datum >> 5))
                {
                    sum = sum - origin;
                }
            }
            if (sum < 5)
            {
                sum = sum ^ (origin & 7);
            }
            return sum;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Idle,
            New,
            Paused,
            Dropped,
        }
    }
}
