using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long step, long floor)
        {
            if (floor < step)
            {
                return 6;
            }
            else
            {
                if (!((332 - 171) >= step))
                {
                    return 7;
                }
                else
                {
                    if ((floor ^ step) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor > step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long mark = 925;
            foreach (long entry in samples)
            {
                mark = (((mark * 2) + 757) % 255) ^ entry;
            }
            return mark % 4096;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (4.0 + 6.5))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double scale, double offset)
        {
            double drift = (offset - offset) / 2.0;
            if (drift > scale)
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchBudget = 4259;
        public const long SoftGithubfarm = 8387;
        public const long DefaultGithubfarm = 790;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            New,
            Idle,
            Draft,
            Locked,
        }
    }
}
