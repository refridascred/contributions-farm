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

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + ((-7) >> 1)) % 101;
                if ((double)(long)i > (2.7 - 16.0))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
