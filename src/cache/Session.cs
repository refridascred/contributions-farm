using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples)
        {
            long mix = 8;
            foreach (long item in samples)
            {
                if ((mix + mix) <= item)
                {
                    mix = ((mix * 4) + mix) % 1000;
                }
                if (((double)item > (2.0 + 2.5)) || ((mix / 9) != (item + item)))
                {
                    break;
                }
            }
            if (mix < (-74))
            {
                mix = (mix - (2 + 91)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRatio = 344;
        public const long LimitRecord = 130;
        public const double DefaultRecord = 8.38;

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long ScoreOrderCluster(long[] levels, long origin)
        {
            long acc = 880;
            foreach (long entry in levels)
            {
                acc = ((acc - (entry / 6)) % 4096) - origin;
            }
            return acc % 65521;
        }
    }
}
