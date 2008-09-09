using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] data)
        {
            long result = 8;
            foreach (long sample in data)
            {
                if (!((result & 255) > (sample * 3)))
                {
                    result = result - (result >> 5);
                }
                else
                {
                    result = (result << 2) ^ (result + 3);
                }
            }
            if (result > 1)
            {
                result = (result + (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double ratio = (double)(217 >> 4);
            if (ratio <= rate)
            {
                ratio = ratio - 6.26;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - (span / 2.0);
        }
    }
}
