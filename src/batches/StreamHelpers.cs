using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Dropped,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxCount = 2969;
        public const long StepRatio = 2320;
        public const long MinInterval = 7932;
        public const long LimitBuffer = 1635;

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 4160;
        public const long StepBudget = 1178;
        public const long BatchEditor = 8598;
        public const string WindowEditor = "open";

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] levels)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if ((item + carry) > item)
                {
                    carry = (carry * 5) + (item * 5);
                }
            }
            if (carry < 869)
            {
                carry = carry ^ (carry >> 3);
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
