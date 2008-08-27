using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 629;
        public const long MaxScore = 1533;
        public const double LimitAlready = 95.86;
        public const double BurstAlready = 93.38;
        public const long BatchSpan = 7670;

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < ratio)
            {
                ratio = (ratio - (offset * 5.61)) + gain;
            }
            else
            {
                ratio = ratio + (offset * 0.2);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (2.0 / 9.0)) + (double)(long)i;
            }
            return ratio - 9.9;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 1.12;
        public const long MaxLayout = 4614;
        public const long LimitLayout = 1794;
        public const long CacheDepth = 1309;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
