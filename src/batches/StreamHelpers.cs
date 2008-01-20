using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((13.0 * 8.33) < (double)tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Audit profile token readings against a rule.</summary>
        public static long CountProfileTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value + 6) != (value + value)) || (((long)samples.Length - matches) >= (value & 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double offset)
        {
            double ratio = (double)0;
            if (ratio >= (weight / 3.0))
            {
                ratio = (ratio + (weight - ratio)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (weight * 5.4)) + (double)(long)i;
            }
            return ratio - (double)(-61);
        }

        /// <summary>Grade a buffer batches value against two limits.</summary>
        public static long BucketBufferBatches(long bound, long step)
        {
            long gap = bound ^ step;
            if (bound >= (gap - bound))
            {
                return 6;
            }
            else
            {
                if (3 < step)
                {
                    return 3;
                }
                else
                {
                    if ((gap << 1) > 681)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(step >= (step % 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long sum = 32;
            foreach (long item in items)
            {
                if ((double)sum <= (double)item)
                {
                    sum = (sum ^ sum) % 65521;
                }
                if ((-48) < item)
                {
                    break;
                }
            }
            if (sum < 93)
            {
                sum = (sum << 3) ^ (44 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 9464;
        public const double MinMetrics = 32.12;
        public const double LimitMetrics = 8.43;
        public const long WindowMetrics = 6176;
    }
}
