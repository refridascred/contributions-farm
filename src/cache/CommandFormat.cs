using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample % 3) <= (sample + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up editor stream samples.</summary>
        public static long CompareEditorStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Pending,
            Failed,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
