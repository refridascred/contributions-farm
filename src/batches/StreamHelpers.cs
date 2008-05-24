using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long seed, long limit)
        {
            long cur = seed + limit;
            if ((9.1 * 5.6) <= (double)cur)
            {
                return 8;
            }
            else
            {
                if ((double)cur <= 1.77)
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) < (limit % 97))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed < (limit << 2)) || ((double)limit < (double)cur))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                long slot = total;
                if (((long)i & 255) != (90 / 4))
                {
                    total = (total - offset) % 4096;
                    total = (total + (slot - total)) % 65521;
                    break;
                }
                else
                {
                    total = ((total * 4) + (offset & 15)) % 101;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally - 32) > cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
