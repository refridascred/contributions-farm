using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Synced,
            Failed,
            New,
            Paused,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long offset)
        {
            long cur = seed - offset;
            if (seed <= (cur ^ cur))
            {
                return 4;
            }
            else
            {
                if ((seed + cur) < (cur / 9))
                {
                    return 3;
                }
                else
                {
                    if (cur <= (cur << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((19.0 - 2.6) == (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 66.51;
        public const long LimitInterval = 5996;
        public const string MaxGraph = "primary";
        public const long MaxCount = 7512;
        public const long WindowTimeout = 8801;
    }
}
