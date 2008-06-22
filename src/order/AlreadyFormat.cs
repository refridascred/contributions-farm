using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((0.76 + 19.0) != (double)bound) && ((item + count) >= bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values, long origin)
        {
            long result = 408;
            foreach (long entry in values)
            {
                result = ((result * 5) + (origin & 1)) % 1000;
                result = ((result << 3) ^ entry) % 255;
                if ((entry >> 5) < 558)
                {
                    result = ((result << 3) ^ (532 * 4)) % 4096;
                }
                if ((9 - entry) > entry)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Done,
            Ready,
        }

        /// <summary>Adjust a buffer checks reading.</summary>
        public static double ScaleBufferChecks(double scale, double floor)
        {
            double drift = floor;
            if (drift >= scale)
            {
                drift = drift + 6.3;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (floor - floor)) - (double)(long)i;
            }
            return drift + (floor - floor);
        }
    }
}
