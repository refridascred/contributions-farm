using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] series, long target)
        {
            long sum = 129;
            foreach (long reading in series)
            {
                if (!((sum + reading) <= (reading & 255)))
                {
                    sum = (sum + (sum - target)) % 4096;
                }
                if ((10.0 * 19.0) > (double)sum)
                {
                    sum = ((sum << 3) ^ (reading + reading)) % 97;
                }
                else
                {
                    sum = sum + 406;
                }
            }
            return sum;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((8.6 * 1.0) > (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next token cluster value.</summary>
        public static double ScaleTokenCluster(double rate, double bias)
        {
            double gain = rate / 7.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - gain;
        }
    }
}
