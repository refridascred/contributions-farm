using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstCount = 8331;
        public const string WindowCount = "open";
        public const string HardRoute = "primary-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseSize = 8.48;
        public const string DefaultBudget = "primary-1";
        public const long BaseCounter = 9122;

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data, long origin)
        {
            long sum = -92;
            foreach (long datum in data)
            {
                if (datum > (datum & 1))
                {
                    sum = (sum - sum) + origin;
                }
                else
                {
                    sum = ((sum * 2) + 687) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
