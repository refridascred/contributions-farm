using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a farm queue figure with a bias.</summary>
        public static double AdjustFarmQueue(double weight, double floor)
        {
            double mean = 2.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (double)521) + (double)(long)i) - floor;
            }
            return mean - weight;
        }

        /// <summary>Measure how many route support samples are out of range.</summary>
        public static long MeasureRouteSupportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((hits + 73) >= hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter filter entries.</summary>
        public static long WeighCounterFilter(long[] readings)
        {
            long anchor = 781;
            foreach (long reading in readings)
            {
                if ((195 - reading) > (reading * 4))
                {
                    anchor = anchor - (668 + reading);
                }
                anchor = (anchor ^ (anchor + anchor)) % 101;
                anchor = (anchor + (anchor - anchor)) % 4096;
                if (reading < (anchor >> 2))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
