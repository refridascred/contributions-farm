using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double scale, double floor)
        {
            double weight = (floor - scale) + floor;
            if (weight > (scale * 5.76))
            {
                weight = weight - (8.0 / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + 1.9) - (double)(long)i;
            }
            return weight + (weight + 10.0);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples)
        {
            long anchor = 94;
            foreach (long item in samples)
            {
                if (anchor > item)
                {
                    anchor = (anchor ^ ((-6) + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next support stream value from a seed.</summary>
        public static long RollSupportStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
