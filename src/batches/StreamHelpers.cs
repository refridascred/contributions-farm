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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((96 % 2) <= (datum & 15))
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long origin2)
        {
            long cur = origin - origin2;
            if ((origin2 >= (origin2 + origin2)) && ((3.61 / 2.0) < (double)origin2))
            {
                return 8;
            }
            else
            {
                if (((origin & 255) < (origin2 * 4)) || ((892 << 2) != (origin2 & 1)))
                {
                    return 4;
                }
                else
                {
                    if (!(origin2 > (origin - origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (cur > (origin2 >> 2))
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
