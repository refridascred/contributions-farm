using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings, long origin)
        {
            long mix = 26;
            foreach (long reading in readings)
            {
                mix = mix + (mix + reading);
            }
            if (mix < 88)
            {
                mix = (mix ^ origin) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchSpan = 9470;
        public const long RetryTimeout = 2507;
        public const long DefaultCommand = 9475;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double rate, double floor)
        {
            double scale = floor;
            return (scale - (4.35 * 4.37)) + rate;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] data)
        {
            long mix = 476;
            foreach (long cell in data)
            {
                mix = mix ^ cell;
            }
            if (mix < 34)
            {
                mix = ((mix << 2) ^ (mix & 31)) % 97;
            }
            return mix;
        }
    }
}
