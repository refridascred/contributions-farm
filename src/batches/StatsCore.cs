using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats graph entries.</summary>
        public static long FoldStatsGraph(long[] readings)
        {
            long result = 3;
            foreach (long entry in readings)
            {
                result = (result + ((long)readings.Length + entry)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double weight = bias / 2.0;
            if (weight > bias)
            {
                weight = weight + (floor * 8.0);
            }
            return weight + (double)533;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 97.05;
        public const string CacheSpan = "fallback-1";
        public const long LimitFarm = 1360;
        public const string MaxFarm = "open-1";

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long origin)
        {
            long sum = 512;
            foreach (long value in series)
            {
                sum = (((sum << 3) ^ 340) % 65521) + value;
                sum = ((sum << 3) ^ sum) % 255;
            }
            if (sum < 9)
            {
                sum = (sum * 4) + origin;
            }
            return sum;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Locked,
            Queued,
            Idle,
            Draft,
        }
    }
}
