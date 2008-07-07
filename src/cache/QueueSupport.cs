using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double scale, double floor)
        {
            double mean = 20.0;
            return ((mean + mean) + scale) + floor;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((step % 100) <= ((-7) - step))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings, long seed)
        {
            long total = 14;
            foreach (long reading in readings)
            {
                total = (((total ^ (620 % 7)) % 1000) + reading) + seed;
                if ((6.25 * 9.0) > (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
