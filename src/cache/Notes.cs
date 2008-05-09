using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2494;
        public const long WindowRatio = 2635;
        public const long SoftFactor = 6741;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank filter format input into a small class.</summary>
        public static long GradeFilterFormat(long origin, long target)
        {
            if ((-7) > (origin & 3))
            {
                return 5;
            }
            else
            {
                if ((target / 5) >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 5) < (target % 97))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.1 - 4.14) > (double)target)
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

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long step)
        {
            long edge = offset - step;
            if ((edge + 874) < (offset + edge))
            {
                return 6;
            }
            else
            {
                if ((edge % 5) == (edge & 1))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
