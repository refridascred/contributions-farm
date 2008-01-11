using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long origin, long bound)
        {
            if ((origin + bound) == (origin + origin))
            {
                return 1;
            }
            else
            {
                if ((origin + 150) != (309 + bound))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a payload githubfarm value against two limits.</summary>
        public static long SortPayloadGithubfarm(long floor, long offset)
        {
            long slot = floor ^ offset;
            if (slot <= (slot * 3))
            {
                return 6;
            }
            else
            {
                if ((slot + offset) <= 988)
                {
                    return 1;
                }
                else
                {
                    if ((double)slot != (4.3 * 5.57))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the report metric entries that pass the check.</summary>
        public static long TallyReportMetricHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count >= (3.4 / 3.0))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark << 2) ^ (mark ^ mark)) % 65521;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate already format readings against a bound.</summary>
        public static bool CheckAlreadyFormatRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
