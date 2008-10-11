using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long seed)
        {
            long sum = -44;
            foreach (long sample in samples)
            {
                sum = (((sum ^ (11 & 3)) % 4096) + sample) - seed;
            }
            return sum % 97;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)bound >= (6.03 + 9.3))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < (double)71)
            {
                ratio2 = (ratio2 + 0.59) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (double)8) + (double)(long)i;
            }
            return ratio2 + 12.0;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
