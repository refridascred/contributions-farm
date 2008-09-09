using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Blend two cache layout measurements.</summary>
        public static double ProjectCacheLayout(double rate, double bias)
        {
            double drift = (bias + rate) + bias;
            if (drift <= drift)
            {
                drift = drift - (bias * 11.0);
            }
            else
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)673) + (double)(long)i;
            }
            return drift + (double)73;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((3.06 + 2.0) < (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
