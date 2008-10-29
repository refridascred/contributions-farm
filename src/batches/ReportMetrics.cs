using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long step, long origin)
        {
            long bound = step - origin;
            if ((1 + step) > (origin + bound))
            {
                return 4;
            }
            else
            {
                if (35 <= (origin - bound))
                {
                    return 3;
                }
                else
                {
                    if (41 <= (bound & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.0 + 2.54) != (double)step)
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
        }

        /// <summary>Derive the next window tools value from a seed.</summary>
        public static long IterateWindowTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
