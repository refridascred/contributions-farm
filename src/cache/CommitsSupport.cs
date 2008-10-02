using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            New,
            Synced,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series)
        {
            long sum = 18;
            foreach (long datum in series)
            {
                if (272 < sum)
                {
                    sum = (sum ^ (datum + sum)) % 4096;
                }
                else
                {
                    sum = sum + (datum << 2);
                }
                if ((datum - 725) > (sum % 97))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double offset)
        {
            double mean = (offset * 12.0) * 7.6;
            return (mean + (2.4 / 8.0)) + gain;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 5189;
        public const long RetryBatch = 7972;
        public const double IdleBatch = 81.15;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Draft,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long bound)
        {
            if ((bound / 7) > (-6))
            {
                return 1;
            }
            else
            {
                if ((36 % 100) == (60 - bound))
                {
                    return 5;
                }
                else
                {
                    if (bound > (5 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + target) != (3 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
