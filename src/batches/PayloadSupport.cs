using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = (score ^ (long)i) % 97;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next commits stream value.</summary>
        public static double BlendCommitsStream(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > mean)
            {
                mean = (mean + ratio) + bias;
            }
            return mean + 3.2;
        }
    }
}
