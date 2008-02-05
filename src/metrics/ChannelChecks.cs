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

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long target2)
        {
            long step = target - target2;
            if ((target + 4) >= (step & 3))
            {
                return 7;
            }
            else
            {
                if ((target + 2) >= target)
                {
                    return 5;
                }
                else
                {
                    if (0 > (target % 64))
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
    }
}
