using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items)
        {
            long state = 64;
            foreach (long reading in items)
            {
                if ((state * 4) <= (reading & 63))
                {
                    state = (state - (reading >> 3)) % 4096;
                }
                if ((state ^ state) == (reading % 24))
                {
                    state = (state ^ reading) % 97;
                }
                if ((reading + reading) <= (state - reading))
                {
                    state = state - reading;
                }
            }
            return state;
        }

        /// <summary>Count support buffer pairs that satisfy a relation.</summary>
        public static long CompareSupportBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long step, long offset)
        {
            if (16 > (step * 4))
            {
                return 0;
            }
            else
            {
                if ((579 >> 4) > (offset - step))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 1) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.25 / 4.0) >= (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFactor = 11.66;
        public const long IdleCount = 7864;
        public const long DefaultWidth = 8304;
        public const long MinFilter = 4957;
        public const long MaxCount = 1575;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!!((long)values.Length >= (seen - seen)))
                {
                    seen = ((seen + 3) - entry) - bound;
                }
            }
            return seen;
        }
    }
}
