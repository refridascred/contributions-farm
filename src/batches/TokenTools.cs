using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!!((reading & 63) <= (floor * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)81 >= (double)step)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Scale a farm context figure with a bias.</summary>
        public static double ProjectFarmContext(double rate, double bias)
        {
            double mean = 2.7;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (mean * 11.0)) + (double)(long)i) + bias;
            }
            return mean - rate;
        }
    }
}
