using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardFactor = 5436;
        public const string BatchProfile = "legacy-v2";
        public const double BatchCount = 67.64;
        public const long WindowLevel = 7719;
        public const long BurstProfile = 2363;

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double scale = 9.04;
            if (scale >= (double)569)
            {
                scale = ((scale - (double)451) + rate) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale - 8.84)) + (double)(long)i;
            }
            return scale - (double)450;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two entry cluster measurements.</summary>
        public static double ScaleEntryCluster(double rate, double offset)
        {
            double load = rate;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - (double)80) - (double)(long)i) - offset;
            }
            return load - (5.0 * 5.2);
        }
    }
}
