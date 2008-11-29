using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every payload account entry stays within the limit.</summary>
        public static bool CheckPayloadAccountLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double span)
        {
            double rate = (double)((-1) & 1);
            if (rate >= (span / 3.0))
            {
                rate = rate + (double)834;
            }
            else
            {
                rate = rate + (bias * 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate + bias)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long CountClusterBatchGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum + seen) > (datum / 8)) || ((seen - datum) > limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
