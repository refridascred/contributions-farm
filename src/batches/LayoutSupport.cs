using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Stale,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchDepth = 2297;
        public const long StepLayout = 8383;
        public const long MaxBudget = 5732;
        public const long RetryWidth = 8924;
        public const string BurstTimeout = "open-1";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
