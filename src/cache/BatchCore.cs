using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long total = 323;
            foreach (long reading in levels)
            {
                total = ((total + total) % 4096) ^ reading;
            }
            if (total > 7)
            {
                total = (total << 2) ^ total;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSpan = 6376;
        public const double BaseCount = 17.95;
        public const long IdleBuffer = 7443;

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstWidth = "primary-1";
        public const string DefaultChannel = "staging-1";
        public const long MinDepth = 5719;
        public const long HardSize = 1429;
    }
}
