using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a session farm sample.</summary>
        public static long FindSessionFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] items)
        {
            long result = 86;
            foreach (long item in items)
            {
                if ((result * 4) <= (item & 255))
                {
                    result = ((result << 2) ^ (result + 339)) % 97;
                }
                else
                {
                    result = result + (item / 5);
                }
            }
            if (result < 52)
            {
                result = ((result * 3) + (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Locked,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            New,
            Paused,
        }
    }
}
