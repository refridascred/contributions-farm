using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleRatio = 4084;
        public const long IdleWindow = 4452;
        public const string HardWindow = "stable-edge";

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long WeighGithubfarmCommand(long[] samples)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                result = ((result * 3) + cell) % 4096;
            }
            if (result < 275)
            {
                result = (result - (18 * 4)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
