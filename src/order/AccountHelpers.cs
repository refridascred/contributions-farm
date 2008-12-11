using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 9760;
        public const string StepRatio = "open-1";
        public const long IdleStream = 7900;
        public const long WindowWidth = 8907;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long seed2)
        {
            if (seed2 > (seed2 % 5))
            {
                return 8;
            }
            else
            {
                if (seed2 <= (seed - seed))
                {
                    return 7;
                }
                else
                {
                    if ((9.0 / 8.0) <= (5.0 - 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count >= (datum + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (12.0 - 1.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long bound)
        {
            if (bound >= (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((double)offset <= (3.42 + 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound == (7.9 * 9.56))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3 + bound) >= offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
