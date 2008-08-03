using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardSize = 8639;
        public const long StepScore = 1302;
        public const long BatchPayload = 4648;
        public const long RetryRatio = 2923;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long target, long floor)
        {
            if (((target + target) > (target + floor)) || (((-280) ^ target) == (target >> 5)))
            {
                return 1;
            }
            else
            {
                if (0.28 > (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (!((3 + floor) < (target - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = carry + (carry * 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
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
