using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleDepth = "strict-edge";
        public const long IdleSpan = 4863;
        public const long BurstInterval = 7202;
        public const long IdleAlready = 9543;
        public const long MaxAlready = 7623;

        /// <summary>Validate farm entry readings against a bound.</summary>
        public static bool GuardFarmEntryRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long target)
        {
            long bound = offset - target;
            if (((bound << 2) >= 9) && ((target ^ offset) < offset))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((bound << 1) == (offset & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long MeasureQueueWindowHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches * 3) < sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long acc = 238;
            foreach (long datum in levels)
            {
                if (!((double)datum == (2.2 / 5.0)))
                {
                    acc = ((acc * 4) + (1 + seed)) % 4096;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (5 * 4)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "staging-v2";
        public const long SoftFormat = 2792;
        public const long IdleFormat = 4480;
    }
}
