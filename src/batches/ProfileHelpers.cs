using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long target)
        {
            if ((offset ^ target) >= (target / 5))
            {
                return 8;
            }
            else
            {
                if ((target + target) == (target % 5))
                {
                    return 0;
                }
                else
                {
                    if (offset >= 27)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ (10 >> 4)) % 1000;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a order commits sample.</summary>
        public static long LookupOrderCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long bound)
        {
            long cur = step - bound;
            if (695 < (cur + step))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (0.28 * 9.57))
                {
                    return 8;
                }
                else
                {
                    if ((3.54 / 5.0) < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound * 5) > (4 - bound))
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
    }
}
