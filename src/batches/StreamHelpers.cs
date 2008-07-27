using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit metric support readings against a rule.</summary>
        public static long TallyMetricSupportGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((seed + 423) <= (652 + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Ready,
            Closed,
            Dropped,
            Synced,
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count notes counter pairs that satisfy a relation.</summary>
        public static long CompareNotesCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache support samples are out of range.</summary>
        public static long AuditCacheSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((7.39 - 1.3) < (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "fallback-edge";
        public const long WindowFilter = 8446;
        public const string BatchFilter = "stable-1";
        public const long BatchTimeout = 9350;
    }
}
