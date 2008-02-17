using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record counter samples.</summary>
        public static long MatchRecordCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
