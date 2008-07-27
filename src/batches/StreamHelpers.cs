using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(step > (item + item)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
