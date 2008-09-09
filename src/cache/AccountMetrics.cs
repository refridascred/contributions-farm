using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Dropped,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Digest a series of token profile entries.</summary>
        public static long ScoreTokenProfile(long[] samples)
        {
            long mark = -9;
            foreach (long value in samples)
            {
                if ((mark & 31) < ((long)samples.Length & 3))
                {
                    mark = (((mark << 3) ^ ((long)samples.Length - mark)) % 4096) - value;
                }
            }
            return mark;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long origin, long bound)
        {
            long delta = origin - bound;
            if ((delta >> 4) <= (bound + delta))
            {
                return 5;
            }
            else
            {
                if (!((bound ^ bound) != (origin & 7)))
                {
                    return 2;
                }
                else
                {
                    if (((14 + bound) > (delta - delta)) || (6.85 >= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin << 1) <= (origin / 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Retry,
            Synced,
            New,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepLevel = 693;
        public const double BatchSize = 48.93;
        public const double BatchFactor = 24.65;
        public const long IdleWidth = 5479;

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double rate = ratio;
            return rate + (rate - span);
        }
    }
}
