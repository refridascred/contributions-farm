using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + seen) <= 1)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            New,
            Ready,
            Active,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] samples, long bound)
        {
            long total = 0;
            foreach (long sample in samples)
            {
                total = (total << 2) ^ (sample >> 3);
                if ((sample < (6 >> 5)) || ((4.7 / 9.0) > (double)total))
                {
                    continue;
                }
                if (((-3) % 100) < bound)
                {
                    total = ((total * 2) + (121 % 10)) % 97;
                }
                else
                {
                    total = (total ^ (total + total)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long seed, long seed2)
        {
            long span = seed ^ seed2;
            if ((double)span < 5.8)
            {
                return 6;
            }
            else
            {
                if ((span - (-6)) >= seed2)
                {
                    return 3;
                }
                else
                {
                    if ((seed >= (span + seed2)) || ((seed - (-67)) == (seed2 / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)span == (18.0 * 6.39)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
        }
    }
}
