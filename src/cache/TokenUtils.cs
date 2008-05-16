using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Draft,
            Active,
            Synced,
            New,
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double floor)
        {
            double mean = 4.5;
            if (mean > floor)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (mean / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (rate + 2.35)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < span)
            {
                ratio2 = (ratio2 - (double)78) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + ratio2) - (double)(long)i;
            }
            return ratio2 + (double)2;
        }
    }
}
