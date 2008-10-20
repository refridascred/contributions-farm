using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepBudget = "primary-v2";
        public const long DefaultTools = 8632;
        public const long BurstTools = 4688;

        /// <summary>Classify a contributi context pair into a bucket.</summary>
        public static long BucketContributiContext(long step, long target)
        {
            if (((9.9 - 13.0) == (double)step) && ((1.5 * 1.4) == (double)step))
            {
                return 3;
            }
            else
            {
                if ((target - 574) < ((-7) - 331))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) <= (step / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double mean = span;
            if (mean >= span)
            {
                mean = (mean - 2.7) - scale;
            }
            return mean + (double)38;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((bound / 9) > (bound2 ^ 969))
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 1) <= seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series, long bound)
        {
            long score = 24;
            foreach (long reading in series)
            {
                score = ((((score << 3) ^ score) % 97) ^ reading) + bound;
            }
            return score;
        }
    }
}
