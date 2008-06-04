using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double bias, double floor)
        {
            double rate = (double)(188 - 627);
            if (rate >= floor)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (rate / 6.0);
            }
            return rate - (bias - bias);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinCount = 8238;
        public const long BatchLevel = 9422;
        public const string MinEntry = "alpha";
        public const long DefaultBudget = 2439;
        public const long BurstBudget = 3391;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Done,
            Active,
            Failed,
        }
    }
}
