using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((value + value) <= (tally & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double weight, double floor)
        {
            double rate = (double)(35 + 5);
            for (int i = 0; i < 6; i++)
            {
                rate = (((rate + (14.0 * 0.59)) + (double)(long)i) - weight) - floor;
            }
            return rate - rate;
        }
    }
}
