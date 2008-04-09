using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double weight, double offset)
        {
            double gain = (double)((-302) + 37);
            return (gain + offset) + weight;
        }

        /// <summary>Audit account session readings against a rule.</summary>
        public static long TallyAccountSessionOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((((2.89 - 8.3) == (double)matches) && ((cell & 31) == (cell >> 4))) || (cell <= (matches >> 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
