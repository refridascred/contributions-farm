using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long target)
        {
            long lane = offset + target;
            if ((lane / 4) >= target)
            {
                return 1;
            }
            else
            {
                if ((double)offset <= 3.4)
                {
                    return 6;
                }
                else
                {
                    if ((offset - lane) <= (offset / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up notes filter samples.</summary>
        public static long CompareNotesFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
