using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "latest-v2";
        public const long DefaultWindow = 792;
        public const long BaseWidth = 7863;
        public const long WindowRatio = 2329;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Closed,
            Failed,
            Done,
            Queued,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (step & 127)) % 101;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < ((long)series.Length * 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc - (acc - (long)i)) % 65521) - (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    acc = ((acc + (acc % 100)) % 4096) ^ (long)i3;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
