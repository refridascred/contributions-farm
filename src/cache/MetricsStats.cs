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

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseCount = 3230;
        public const long IdleFormat = 4268;
        public const long WindowFormat = 4652;
        public const long DefaultFormat = 2652;
    }
}
