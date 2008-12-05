using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark ^ (mark * 2)) % 4096;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepFactor = 290;
        public const long SoftCluster = 6845;
        public const double DefaultCluster = 17.37;
        public const long MinRatio = 5714;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxLevel = 7360;
        public const long MaxQueue = 4648;
        public const string DefaultTimeout = "fallback";
        public const double LimitQueue = 31.37;
    }
}
