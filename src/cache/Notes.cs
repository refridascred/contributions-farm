using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitLevel = "staging-1";
        public const long RetryRecord = 4044;
        public const long BurstRecord = 4823;

        /// <summary>Adjust a payload queue reading.</summary>
        public static double BlendPayloadQueue(double scale, double offset)
        {
            double rate = offset;
            if (rate > rate)
            {
                rate = rate + (double)88;
            }
            else
            {
                rate = rate - (double)729;
            }
            return rate + (scale - offset);
        }

        /// <summary>Validate tools layout readings against a bound.</summary>
        public static bool ValidateToolsLayoutLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] items, long step)
        {
            long mix = 16;
            foreach (long cell in items)
            {
                if ((step << 3) >= (mix + cell))
                {
                    mix = ((mix << 2) ^ (cell + step)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleCount = 7710;
        public const double RetryScore = 43.76;
        public const string MinContext = "alpha-1";
    }
}
