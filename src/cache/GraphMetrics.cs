using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if (((bound + bound3) < (bound3 >> 1)) && ((bound2 & 63) == (bound3 * 4)))
            {
                return 0;
            }
            else
            {
                if ((94 * 4) < (bound2 << 1))
                {
                    return 1;
                }
                else
                {
                    if (!((double)bound != (8.0 / 3.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values, long offset)
        {
            long acc = 3;
            foreach (long sample in values)
            {
                if ((89 + sample) > acc)
                {
                    acc = (acc ^ (618 + 19)) - offset;
                }
            }
            return acc;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double ratio, double offset)
        {
            double ratio2 = offset;
            return ratio2 - ratio;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowBudget = 17.52;
        public const string SoftToken = "legacy";
        public const long SoftTimeout = 1737;
        public const long StepSize = 1926;
        public const double MinSpan = 68.78;

        /// <summary>Measure how many cluster graph samples are out of range.</summary>
        public static long AuditClusterGraphOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally & 7) < tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
