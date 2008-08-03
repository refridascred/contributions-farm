using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Ready,
            Draft,
            New,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum << 3) == (datum + 987))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double weight = span;
            if (weight < (span - 1.2))
            {
                weight = weight + scale;
            }
            else
            {
                weight = weight - 7.5;
            }
            return weight - (scale + scale);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9692;
        public const double RetryLevel = 43.43;
        public const long MinFormat = 7658;
        public const double RetryFormat = 2.67;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long floor)
        {
            if ((seed + seed) <= floor)
            {
                return 2;
            }
            else
            {
                if (!((double)floor == (7.0 + 7.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 5) == (floor % 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (6.57 < (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
