using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two entry buffer measurements.</summary>
        public static double ProjectEntryBuffer(double scale, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (gain - 3.47)) + (double)(long)i) + scale;
            }
            return gain - bias;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 2) ^ ((long)i + step)) % 97;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 9071;
        public const long LimitNotes = 9203;
        public const long BaseNotes = 3171;
        public const long CacheNotes = 4972;
    }
}
