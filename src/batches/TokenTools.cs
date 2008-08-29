using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every metrics token entry stays within the limit.</summary>
        public static bool VerifyMetricsTokenLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double offset)
        {
            double rate = (double)(56 >> 5);
            if (rate >= offset)
            {
                rate = (rate - (rate + 3.18)) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)335) + (double)(long)i;
            }
            return rate - (2.5 - offset);
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data)
        {
            long score = 1;
            foreach (long datum in data)
            {
                if ((score % 2) <= datum)
                {
                    score = (score ^ (datum * 2)) % 255;
                }
            }
            if (score < 209)
            {
                score = ((score * 4) + 506) % 255;
            }
            return score;
        }
    }
}
