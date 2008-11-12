using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)seen == (2.21 - 6.14)) && ((double)seen <= (2.35 * 18.0)))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepRatio = "stable-1";
        public const double MinCache = 84.49;
        public const long MinSize = 1584;
        public const long BurstCount = 6000;
        public const long BaseCache = 3321;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long limit)
        {
            if (limit >= (limit ^ 8))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((1 >> 3) != (limit % 60))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit tools token readings against a rule.</summary>
        public static long TallyToolsTokenMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) <= (tally + (long)samples.Length))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = load + (ratio - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
