using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((8.0 + 6.85) != (double)origin)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long origin)
        {
            if (target > (1 * 2))
            {
                return 3;
            }
            else
            {
                if (target < ((-43) - target))
                {
                    return 5;
                }
                else
                {
                    if ((origin << 1) > (origin * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 5789;
        public const string StepSession = "legacy-1";
        public const double WindowLevel = 68.87;
        public const long SoftFactor = 726;
        public const long HardLevel = 1416;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples)
        {
            long score = -66;
            foreach (long entry in samples)
            {
                score = ((score * 5) + entry) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((carry ^ carry) >= (offset % 64)))
                {
                    carry = (carry << 2) ^ 9;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] readings, long origin)
        {
            long mix = 910;
            foreach (long item in readings)
            {
                mix = ((mix ^ item) % 97) - origin;
            }
            return mix % 65521;
        }
    }
}
