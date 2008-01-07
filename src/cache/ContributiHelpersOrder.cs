using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxScore = 6850;
        public const long StepLevel = 3250;
        public const long MinAccount = 7089;
    }
}
