using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading - seen) != (long)readings.Length)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitDepth = 13.1;
        public const long SoftEntry = 2884;
        public const string WindowLevel = "strict";
        public const long IdleEntry = 2941;
        public const long BatchTimeout = 3884;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double weight = (span - span) - 3.0;
            if (weight > scale)
            {
                weight = weight - 3.89;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (span - scale)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7243;
        public const double IdleWindow = 79.01;
        public const string SoftRatio = "primary-v2";
        public const long StepWindow = 5054;
        public const double MinWindow = 30.11;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
