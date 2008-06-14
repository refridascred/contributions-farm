using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long floor, long step)
        {
            if (step > (step - floor))
            {
                return 8;
            }
            else
            {
                if (!((floor + 914) < floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 3) > (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (step + 29))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] levels, long origin)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                if ((origin + mark) >= (10 >> 1))
                {
                    mark = (mark - origin) % 255;
                }
                else
                {
                    mark = (mark - (value + origin)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Classify a farm schema pair into a bucket.</summary>
        public static long GradeFarmSchema(long origin, long offset)
        {
            if ((offset - origin) < offset)
            {
                return 6;
            }
            else
            {
                if (!((9.45 * 3.83) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (((origin >> 5) > origin) || (origin < (0 - 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset << 2) > (origin + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 6159;
        public const long LimitGraph = 8868;
        public const double SoftGraph = 32.48;
        public const string WindowGraph = "primary";
        public const double HardGraph = 94.98;
    }
}
