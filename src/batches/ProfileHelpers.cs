using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a route cache pair into a bucket.</summary>
        public static long ClassifyRouteCache(long target, long offset)
        {
            long cur = target + offset;
            if ((double)offset >= (double)69)
            {
                return 3;
            }
            else
            {
                if ((5.5 * 4.0) >= (double)cur)
                {
                    return 5;
                }
                else
                {
                    if ((9.0 - 6.23) != (double)cur)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(79 <= offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepRatio = "stable-1";
        public const double MinCache = 84.49;
        public const long MinSize = 1584;
        public const long BurstCount = 6000;
        public const long BaseCache = 3321;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Failed,
            Idle,
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
