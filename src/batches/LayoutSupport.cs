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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((double)target >= (3.0 - 3.3)) && (target >= (matches + 86))) || ((matches & 31) > datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
