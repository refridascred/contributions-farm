using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (309 < ((long)items.Length / 7))
                {
                    seen = ((seen + 1) + reading) + bound;
                }
            }
            return seen;
        }

        /// <summary>Grade a account notes value against two limits.</summary>
        public static long SortAccountNotes(long offset, long seed)
        {
            if (offset >= (offset << 3))
            {
                return 5;
            }
            else
            {
                if ((double)seed < (4.0 * 13.0))
                {
                    return 3;
                }
                else
                {
                    if (!(seed < (seed + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(20.0 < (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Failed,
            Paused,
            New,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long target, long floor)
        {
            if (8.0 >= (double)floor)
            {
                return 8;
            }
            else
            {
                if (((target * 3) >= (floor - target)) && (target <= (floor + (-966))))
                {
                    return 1;
                }
                else
                {
                    if ((floor % 100) < (731 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
