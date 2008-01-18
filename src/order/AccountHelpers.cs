using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 6374;
        public const string MinCount = "local-edge";
        public const double BatchSize = 47.74;
        public const long SoftLayout = 5139;
        public const long WindowLayout = 7366;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleBudget = 4922;
        public const long IdleGraph = 1108;
        public const long WindowInterval = 8348;
        public const double HardInterval = 20.55;

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstInterval = "primary-1";
        public const double BurstReport = 62.12;
        public const long HardReport = 9376;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first token notes entry that matches the target.</summary>
        public static long SeekTokenNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
