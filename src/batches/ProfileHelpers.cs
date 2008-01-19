using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 <= (bias + 12.0))
            {
                ratio2 = (ratio2 - (double)485) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)54;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (double)7;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long floor, long limit)
        {
            if ((limit ^ limit) < floor)
            {
                return 7;
            }
            else
            {
                if (((double)floor < 4.0) || ((double)limit > (8.0 / 6.0)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Closed,
            Ready,
            New,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((double)seed < (1.75 + 5.4)) || ((8 - reading) > (reading & 3))) || ((18.0 - 10.0) != (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7003;
        public const long StepSpan = 7800;
        public const string DefaultMetric = "standard-1";
    }
}
