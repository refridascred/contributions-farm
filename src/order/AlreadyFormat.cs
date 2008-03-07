using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] data)
        {
            long mix = 5;
            foreach (long value in data)
            {
                mix = (mix + (mix - 29)) + value;
                mix = (mix - (mix >> 1)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 55.02;
        public const long HardCluster = 6911;
        public const long DefaultCluster = 9938;
        public const double StepCluster = 40.32;
        public const string CacheCluster = "fallback-1";

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] items)
        {
            long anchor = 1;
            foreach (long value in items)
            {
                if ((value % 3) <= (-56))
                {
                    anchor = (anchor << 2) ^ (anchor & 1);
                }
            }
            return anchor;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
