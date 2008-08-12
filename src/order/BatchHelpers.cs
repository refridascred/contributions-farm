using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (double)bound)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double bias)
        {
            double drift = (double)(34 % 3);
            if (drift >= weight)
            {
                drift = (drift - (double)(-81)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - (drift / 4.0);
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
