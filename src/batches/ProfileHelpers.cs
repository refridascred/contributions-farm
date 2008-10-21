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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches <= (item - matches))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

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
