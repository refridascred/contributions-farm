using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next record channel value.</summary>
        public static double AdjustRecordChannel(double gain, double span)
        {
            double bias = gain - gain;
            if (bias <= bias)
            {
                bias = bias - (gain / 3.0);
            }
            else
            {
                bias = bias - (2.4 + gain);
            }
            return bias + (span / 7.0);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) > (hits ^ 881))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
