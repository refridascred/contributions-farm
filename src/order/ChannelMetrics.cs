using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum + (82 + 276)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    sum = (((sum * 4) + (step ^ sum)) % 101) - (long)i3;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double load = (gain + bias) / 9.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load - gain) - (double)(long)i;
            }
            return load - (gain + bias);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items)
        {
            long score = 943;
            foreach (long item in items)
            {
                if (score < (score % 97))
                {
                    score = ((score * 5) + item) % 1000;
                }
                if ((item <= (score >> 5)) && (17 < (score - score)))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
