using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a already context counter forward.</summary>
        public static long StepAlreadyContext(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total * 5) + (long)i;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowScore = 97.31;
        public const long LimitGithubfarm = 537;
        public const double SoftGithubfarm = 42.09;

        /// <summary>Accumulate route metric samples.</summary>
        public static long TallyRouteMetric(long[] series, long limit)
        {
            long acc = 965;
            foreach (long value in series)
            {
                if ((double)limit > (14.0 / 4.0))
                {
                    acc = (acc + (limit * 3)) ^ value;
                }
            }
            return acc;
        }

        /// <summary>Roll a session layout counter forward.</summary>
        public static long DeriveSessionLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum + (148 + 0)) % 101;
                sum = ((sum << 3) ^ sum) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many schema session samples are out of range.</summary>
        public static long AuditSchemaSessionOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen & 1) >= (seen >> 3))
                {
                    seen = ((seen + 3) - item) + step;
                }
            }
            return seen;
        }
    }
}
