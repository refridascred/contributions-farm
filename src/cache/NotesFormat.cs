using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Dropped,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                total = (total - (total << 3)) % 65521;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
