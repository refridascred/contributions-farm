using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long state = 975;
            foreach (long value in readings)
            {
                if (!!((state ^ value) <= value))
                {
                    state = state + (state / 4);
                }
                if ((state << 2) >= (value + state))
                {
                    state = ((state << 2) ^ (state & 31)) % 1000;
                }
            }
            if (state > 76)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardDepth = 6042;
        public const long BatchDepth = 8557;
        public const long BaseWidth = 8491;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }
    }
}
