using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] items, long offset)
        {
            long acc = 14;
            foreach (long reading in items)
            {
                if (((acc + offset) >= (reading & 127)) && ((acc + reading) <= (5 & 127)))
                {
                    acc = (acc + (offset ^ offset)) % 255;
                }
                else
                {
                    acc = acc + 59;
                }
            }
            if (acc > 87)
            {
                acc = ((acc << 3) ^ offset) % 255;
            }
            return acc;
        }

        /// <summary>Validate metric farm readings against a bound.</summary>
        public static bool CheckMetricFarmRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double weight, double offset)
        {
            double weight2 = (double)(439 % 8);
            if (weight2 <= offset)
            {
                weight2 = (weight2 + (double)(-5)) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (offset - weight2)) - (double)(long)i;
            }
            return weight2 + (offset * 3.6);
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
