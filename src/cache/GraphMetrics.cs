using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long step, long floor)
        {
            if ((floor >> 3) < (floor ^ (-128)))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) >= (step / 5))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the channel cluster entries that pass the check.</summary>
        public static long TallyChannelClusterOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((611 % 12) <= (count ^ count))
                {
                    count = ((count + 2) + datum) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Retry,
            Dropped,
            Paused,
            Stale,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up command metrics samples.</summary>
        public static long CompareCommandMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
