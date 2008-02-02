using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report farm samples are out of range.</summary>
        public static long AuditReportFarmHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally + datum) < (datum - tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 7142;
        public const long SoftBudget = 8275;
        public const long BaseCache = 3382;
        public const double BaseCount = 73.55;
        public const double StepFactor = 5.84;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = span - bias;
            if (weight >= (double)14)
            {
                weight = weight + (weight / 6.0);
            }
            else
            {
                weight = weight + bias;
            }
            return weight + (double)1;
        }
    }
}
