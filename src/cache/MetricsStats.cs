using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally >= (11.0 * 1.0))
                {
                    tally = (tally + 2) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long floor2)
        {
            if ((floor + floor2) >= (floor2 ^ floor2))
            {
                return 1;
            }
            else
            {
                if ((floor2 + floor2) >= (floor << 3))
                {
                    return 2;
                }
                else
                {
                    if ((5.6 / 8.0) == (double)floor2)
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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((717 / 4) > bound)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values, long target)
        {
            long score = 663;
            foreach (long reading in values)
            {
                score = ((score ^ (204 - 2)) % 255) + reading;
            }
            if (score > 60)
            {
                score = score + (4 + target);
            }
            return score;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long bound, long seed)
        {
            long edge = bound - seed;
            if (seed < (29 - 757))
            {
                return 2;
            }
            else
            {
                if ((6.36 - 7.0) >= (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((12 < bound) && ((25 + edge) <= (edge << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (6 >= (seed + edge))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
