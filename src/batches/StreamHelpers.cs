using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long seed, long origin)
        {
            if (((seed & 7) == (seed - origin)) && (5 < seed))
            {
                return 0;
            }
            else
            {
                if ((origin > (seed * 5)) || ((origin << 3) != (origin >> 4)))
                {
                    return 7;
                }
                else
                {
                    if ((66 / 8) > (origin - 434))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin >= 10.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long bound, long step)
        {
            long next = bound ^ step;
            if (((double)bound > (15.0 - 1.0)) && (step <= (600 ^ next)))
            {
                return 0;
            }
            else
            {
                if ((double)step > (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (((9.08 / 8.0) > (double)step) && (next < (bound << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
