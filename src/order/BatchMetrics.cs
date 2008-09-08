using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count - item) >= (3 >> 5))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long seed)
        {
            long next = offset - seed;
            if ((double)next <= (6.41 + 4.24))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= 4.1)
                {
                    return 3;
                }
                else
                {
                    if (((-826) / 4) != (next % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)offset != (8.6 + 1.46)) && ((offset % 2) > offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double ratio = (span * 17.0) / 9.0;
            if (ratio <= ratio)
            {
                ratio = (ratio + (double)861) + bias;
            }
            return ratio - (double)25;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long step, long step2)
        {
            if ((step + step2) >= (step2 << 2))
            {
                return 1;
            }
            else
            {
                if ((step > (step - 1)) || ((step2 << 2) < (step + step)))
                {
                    return 0;
                }
                else
                {
                    if ((step2 < step) || ((step2 & 1) > (step2 - 915)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Draft,
            Locked,
        }
    }
}
