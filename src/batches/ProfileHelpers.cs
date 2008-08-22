using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double weight = gain;
            if (weight > (5.63 - 3.2))
            {
                weight = (weight - (double)596) + floor;
            }
            return weight - (2.5 * 4.46);
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double scale, double offset)
        {
            double bias = offset;
            return (bias + (double)908) + scale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 8223;
        public const long LimitSchema = 6931;
        public const string CacheSchema = "latest-1";
        public const long BaseSchema = 9410;
        public const double WindowSchema = 46.6;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
