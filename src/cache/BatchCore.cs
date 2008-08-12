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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading % 12) == (reading >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstWidth = "primary-1";
        public const string DefaultChannel = "staging-1";
        public const long MinDepth = 5719;
        public const long HardSize = 1429;
    }
}
