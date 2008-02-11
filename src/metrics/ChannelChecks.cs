using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long floor, long target)
        {
            if ((floor - floor) <= target)
            {
                return 3;
            }
            else
            {
                if ((7.28 / 8.0) > (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor > (7 ^ (-58))) && (69 > target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor % 3) == (floor & 63))
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
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank format metrics input into a small class.</summary>
        public static long GradeFormatMetrics(long target, long seed)
        {
            long step = target - seed;
            if ((seed + seed) < (60 + seed))
            {
                return 3;
            }
            else
            {
                if (step >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (target << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((offset + offset) < offset)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks window samples.</summary>
        public static long WeighChecksWindow(long[] samples, long target)
        {
            long sum = 7;
            foreach (long value in samples)
            {
                if ((sum + target) > (value - target))
                {
                    sum = (sum - target) % 1000;
                }
                if ((double)target <= 8.3)
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = (sum - (483 + sum)) % 255;
            }
            return sum;
        }
    }
}
