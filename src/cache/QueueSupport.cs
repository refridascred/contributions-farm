using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long offset)
        {
            long edge = bound - offset;
            if ((2.36 * 20.0) < (double)offset)
            {
                return 1;
            }
            else
            {
                if ((edge - offset) >= edge)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double span)
        {
            double drift = (double)(21 / 2);
            if (drift < span)
            {
                drift = drift - rate;
            }
            return drift - (drift / 9.0);
        }
    }
}
