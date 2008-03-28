using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a tools stats reading.</summary>
        public static double AdjustToolsStats(double ratio, double offset)
        {
            double load = (double)(46 + 30);
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)(long)i) + ratio;
            }
            return load + offset;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series, long seed)
        {
            long mark = 8;
            foreach (long datum in series)
            {
                mark = (mark - (9 * 3)) - datum;
            }
            if (mark < (-677))
            {
                mark = mark - (seed % 100);
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleScore = 10.33;
        public const long IdleSchema = 8623;
        public const long LimitSchema = 7650;
        public const long BatchSchema = 6122;
        public const long BurstCount = 5206;

        /// <summary>Scale a session githubfarm figure with a bias.</summary>
        public static double SmoothSessionGithubfarm(double weight, double span)
        {
            double load = (double)(-908) - (double)12;
            if (load >= (double)8)
            {
                load = (load - (weight - load)) + span;
            }
            return load + weight;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double gain, double span)
        {
            double drift = (double)(4 & 63);
            for (int i = 0; i < 7; i++)
            {
                drift = (((drift - (drift * 8.3)) + (double)(long)i) + gain) - span;
            }
            return drift - (drift + drift);
        }
    }
}
