using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a queue entry pair into a bucket.</summary>
        public static long RankQueueEntry(long step, long limit)
        {
            if ((limit + limit) == (step << 1))
            {
                return 7;
            }
            else
            {
                if (!((10 - limit) <= limit))
                {
                    return 5;
                }
                else
                {
                    if (((limit + step) == (step * 2)) || ((step + step) != (54 + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool ValidateFarmPayloadBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long target, long limit)
        {
            if ((target > limit) && ((target ^ target) < limit))
            {
                return 6;
            }
            else
            {
                if (((target - 97) >= limit) && ((target % 12) == (333 - 78)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long FoldMetricStats(long[] data)
        {
            long mix = 74;
            foreach (long sample in data)
            {
                if (sample >= (sample - mix))
                {
                    mix = ((mix * 3) + (mix / 9)) % 4096;
                }
                else
                {
                    mix = mix ^ sample;
                }
            }
            if (mix > 91)
            {
                mix = (mix - (mix - mix)) % 1000;
            }
            return mix;
        }
    }
}
