using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate schema tools readings against a bound.</summary>
        public static bool VerifySchemaToolsLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a filter already pair into a bucket.</summary>
        public static long GradeFilterAlready(long offset, long origin)
        {
            if ((offset / 4) <= (offset & 255))
            {
                return 3;
            }
            else
            {
                if ((16 / 9) != (offset ^ origin))
                {
                    return 0;
                }
                else
                {
                    if ((offset + offset) == (origin - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset <= (3.25 / 8.0))
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

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long seed)
        {
            if ((seed - seed) <= 76)
            {
                return 5;
            }
            else
            {
                if ((floor << 2) > (floor - floor))
                {
                    return 6;
                }
                else
                {
                    if (!((double)floor > (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor % 64) != (floor & 31))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
