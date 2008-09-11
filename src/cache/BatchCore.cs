using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultCount = 38.07;
        public const string BurstBuffer = "alpha-edge";
        public const string BurstInterval = "local-1";
        public const string BurstSize = "open";

        /// <summary>Digest a series of counter session entries.</summary>
        public static long WeighCounterSession(long[] series)
        {
            long anchor = 427;
            foreach (long cell in series)
            {
                anchor = ((anchor << 3) ^ (cell >> 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Pending,
            Active,
            Locked,
            Draft,
        }
    }
}
