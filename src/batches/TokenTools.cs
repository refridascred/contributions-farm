using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double gain, double offset)
        {
            double drift = (double)3 - (double)99;
            return ((drift - (double)1) + gain) + offset;
        }

        /// <summary>Check that every report schema entry stays within the limit.</summary>
        public static bool VerifyReportSchemaLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
