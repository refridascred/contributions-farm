using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = (total + ((long)i + total)) % 65521;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((0 >= (tally >> 4)) || ((double)tally >= (double)(long)samples.Length)) || ((tally % 10) != (549 - bound)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long mark = 423;
            foreach (long datum in items)
            {
                mark = (mark ^ (datum / 3)) % 97;
                if ((mark - mark) == (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit payload channel readings against a rule.</summary>
        public static long AuditPayloadChannelGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length <= (2 * 3)) || !((seed << 2) > 0))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route profile pair into a bucket.</summary>
        public static long BucketRouteProfile(long floor, long seed)
        {
            if ((floor - seed) == (floor + seed))
            {
                return 8;
            }
            else
            {
                if ((seed + seed) == (floor ^ 233))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
