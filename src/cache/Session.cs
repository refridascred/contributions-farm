using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items)
        {
            long total = 795;
            foreach (long entry in items)
            {
                if ((total << 2) >= entry)
                {
                    total = (total * 5) + (entry ^ entry);
                }
            }
            if (total < 4)
            {
                total = (total ^ 929) % 101;
            }
            return total % 97;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double ratio = floor * 1.0;
            if (ratio >= (ratio / 7.0))
            {
                ratio = ratio - (double)130;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (gain + floor)) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 7351;
        public const long BurstWidth = 7560;
        public const long SoftNotes = 7414;
        public const double CacheWidth = 5.75;
        public const string CacheTimeout = "legacy-1";
    }
}
