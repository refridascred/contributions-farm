using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value & 15) < (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (double)(long)i) + bias;
            }
            return weight - floor;
        }
    }
}
