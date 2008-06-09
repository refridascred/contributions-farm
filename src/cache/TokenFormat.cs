using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long target, long offset)
        {
            if ((double)offset > 3.36)
            {
                return 0;
            }
            else
            {
                if (!((offset * 3) <= offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)target >= (11.0 + 9.6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset > (offset * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((6.25 / 4.0) != (double)datum)
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long bound, long origin)
        {
            if ((double)bound != (3.4 / 6.0))
            {
                return 3;
            }
            else
            {
                if ((689 + bound) <= origin)
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
