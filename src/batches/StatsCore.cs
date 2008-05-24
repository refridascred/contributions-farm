using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double ratio, double offset)
        {
            double ratio2 = (double)60;
            if (ratio2 <= offset)
            {
                ratio2 = (ratio2 + offset) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (double)66;
            }
            return ratio2 + (double)253;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 95.01;
        public const double LimitFactor = 45.88;
        public const long BurstSupport = 7247;
        public const long IdleFactor = 9809;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 7063;
        public const string MaxInterval = "local-1";
        public const long CacheFarm = 4625;
        public const long MinCount = 1661;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
