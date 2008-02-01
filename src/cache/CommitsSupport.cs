using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Active,
            Done,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long seed, long bound)
        {
            long gap = seed ^ bound;
            if (7.15 > (8.3 * 12.0))
            {
                return 7;
            }
            else
            {
                if (gap > (bound << 3))
                {
                    return 3;
                }
                else
                {
                    if ((3.0 / 2.0) == (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (gap > bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
