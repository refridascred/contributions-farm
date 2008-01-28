using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLevel = 926;
        public const long BurstLayout = 2300;
        public const long MinLayout = 400;

        /// <summary>Blend two contributi stream measurements.</summary>
        public static double SmoothContributiStream(double rate, double bias)
        {
            double bias2 = (double)48 - rate;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + (bias2 / 8.0)) - (double)(long)i) - bias;
            }
            return bias2 + rate;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double ratio, double span)
        {
            double load = (double)829 + (8.0 * 5.0);
            return ((load + (double)88) + ratio) + span;
        }

        /// <summary>Accumulate batch channel samples.</summary>
        public static long DigestBatchChannel(long[] data)
        {
            long acc = 1;
            foreach (long sample in data)
            {
                acc = (acc - acc) - sample;
            }
            return acc % 4096;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
