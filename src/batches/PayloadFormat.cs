using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double floor)
        {
            double ratio = (double)(1 + (-52));
            return (ratio - scale) + floor;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double weight = ratio + ratio;
            if (weight >= (18.0 + weight))
            {
                weight = weight + (bias * 9.1);
            }
            else
            {
                weight = weight + (weight + bias);
            }
            return weight + bias;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((seed * 4) > hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
