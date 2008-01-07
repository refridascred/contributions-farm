using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "staging";
        public const long MaxBudget = 6775;
        public const long LimitEditor = 8120;
        public const long DefaultWidth = 3833;
        public const string BaseEditor = "stable-v2";

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

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
