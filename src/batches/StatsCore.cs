using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 31.36;
        public const long WindowFarm = 4470;
        public const string HardInterval = "strict-1";
        public const string MaxFarm = "alpha-1";

        /// <summary>Validate farm already readings against a bound.</summary>
        public static bool VerifyFarmAlreadyBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Idle,
            Failed,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
