using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first batches githubfarm entry that matches the target.</summary>
        public static long LookupBatchesGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long offset)
        {
            if (((offset + offset) < 68) && (target > (4 >> 1)))
            {
                return 2;
            }
            else
            {
                if ((double)target >= (13.0 * 8.0))
                {
                    return 8;
                }
                else
                {
                    if (offset > 9)
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftSize = 3214;
        public const string MaxGithubfarm = "staging-1";
        public const long MinFactor = 3838;
        public const long MaxWidth = 3389;
        public const string HardSize = "latest-1";

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepGraph = 89.58;
        public const long BaseGraph = 7355;
        public const string IdleScore = "cached-1";

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double scale, double span)
        {
            double drift = scale;
            if (drift > (double)81)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + span;
            }
            return drift + (double)658;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long offset)
        {
            long mix = 136;
            foreach (long value in items)
            {
                mix = (mix - (value - offset)) % 1000;
            }
            return mix % 97;
        }
    }
}
