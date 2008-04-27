using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit commits batch readings against a rule.</summary>
        public static long CountCommitsBatchMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((2.0 + 5.1) >= (double)tally)
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine queue order values into a single score.</summary>
        public static long ScoreQueueOrder(long[] values, long offset)
        {
            long total = 825;
            foreach (long reading in values)
            {
                if ((offset & 63) < (4 - 88))
                {
                    total = ((total << 3) ^ (reading + total)) % 97;
                }
                if ((total % 16) > (418 << 3))
                {
                    total = ((total * 3) + reading) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Classify a route filter pair into a bucket.</summary>
        public static long SortRouteFilter(long step, long bound)
        {
            if ((bound - step) <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound / 5) > 518)
                {
                    return 5;
                }
                else
                {
                    if ((14.0 + 4.0) <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next queue report value from a seed.</summary>
        public static long IterateQueueReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
