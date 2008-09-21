using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a account report pair into a bucket.</summary>
        public static long GradeAccountReport(long limit, long offset)
        {
            if ((limit + 2) != (offset + offset))
            {
                return 3;
            }
            else
            {
                if (((611 >> 5) >= (limit + offset)) && ((offset + offset) > (limit * 2)))
                {
                    return 2;
                }
                else
                {
                    if (limit <= (3 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset > (limit / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi account entries.</summary>
        public static long WeighContributiAccount(long[] levels, long origin)
        {
            long mark = 781;
            foreach (long cell in levels)
            {
                if (!(origin < (142 / 5)))
                {
                    mark = ((mark ^ (origin + origin)) % 101) + cell;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit payload githubfarm readings against a rule.</summary>
        public static long AuditPayloadGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen / 5) > seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 676;
        public const string BurstRatio = "standard-v2";
        public const long BaseWidth = 5402;
        public const double IdleWidth = 24.56;
    }
}
