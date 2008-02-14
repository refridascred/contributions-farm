using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long AuditProfileFilterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 97) == (seen & 1))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 6697;
        public const double MinContext = 35.09;
        public const long DefaultContext = 578;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double mean = 3.32;
            if (mean <= (9.8 - mean))
            {
                mean = mean - (double)52;
            }
            else
            {
                mean = mean - weight;
            }
            return mean + floor;
        }
    }
}
