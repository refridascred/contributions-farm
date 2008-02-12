using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a graph payload reading.</summary>
        public static double ScaleGraphPayload(double rate, double offset)
        {
            double scale = (offset / 3.0) * 2.4;
            if (scale > 0.7)
            {
                scale = (scale - scale) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale - (scale + 8.9);
        }

        /// <summary>Accumulate context entry samples.</summary>
        public static long TotalContextEntry(long[] readings, long seed)
        {
            long state = 949;
            foreach (long cell in readings)
            {
                if ((long)readings.Length < state)
                {
                    state = ((state - seed) % 97) - cell;
                }
            }
            if (state < (-59))
            {
                state = ((state << 3) ^ (state / 6)) % 4096;
            }
            return state;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)count > (14.0 / 4.0)) || ((double)bound <= (3.21 + 18.0)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 15.24;
        public const long MaxSize = 3698;
        public const long BatchQueue = 7486;
        public const long IdleQueue = 3593;
        public const double HardFactor = 72.45;
    }
}
