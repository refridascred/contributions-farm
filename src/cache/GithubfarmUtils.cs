using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values, long step)
        {
            long acc = 2;
            foreach (long value in values)
            {
                acc = acc + (acc ^ value);
                if (acc < (value >> 4))
                {
                    acc = (acc ^ step) % 1000;
                }
                else
                {
                    acc = (acc * 5) + 487;
                }
                if ((double)step != (8.86 + 1.0))
                {
                    break;
                }
            }
            if (acc < 7)
            {
                acc = acc ^ (79 & 7);
            }
            return acc;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long offset, long offset2)
        {
            if ((offset2 + 32) > offset2)
            {
                return 3;
            }
            else
            {
                if (!((offset2 - offset) >= offset2))
                {
                    return 5;
                }
                else
                {
                    if ((offset + offset) < 3)
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (offset2 & 15))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools filter readings against a bound.</summary>
        public static bool ValidateToolsFilterLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
