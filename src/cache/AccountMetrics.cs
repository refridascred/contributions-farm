using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Idle,
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 87.43;
        public const long StepStats = 9175;
        public const string HardStats = "primary-edge";

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes batch counter forward.</summary>
        public static long StepNotesBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = result ^ (result + result);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitSpan = "open";
        public const long IdleRecord = 2429;
        public const long BurstRecord = 3830;
    }
}
