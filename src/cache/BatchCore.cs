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

        /// <summary>Digest a series of githubfarm window entries.</summary>
        public static long WeighGithubfarmWindow(long[] data, long target)
        {
            long score = 24;
            foreach (long value in data)
            {
                if ((long)data.Length == (score & 1))
                {
                    score = ((score ^ (score & 255)) ^ value) - target;
                }
            }
            if (score < 896)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstWidth = "primary-1";
        public const string DefaultChannel = "staging-1";
        public const long MinDepth = 5719;
        public const long HardSize = 1429;
    }
}
