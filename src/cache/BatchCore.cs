using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate cache notes samples.</summary>
        public static long TotalCacheNotes(long[] items)
        {
            long state = 4;
            foreach (long entry in items)
            {
                state = ((state * 2) + (entry / 4)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples)
        {
            long acc = 5;
            foreach (long cell in samples)
            {
                acc = ((acc * 3) + (long)samples.Length) - cell;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowLevel = 9366;
        public const string WindowNotes = "open-1";
        public const long MinInterval = 9150;
    }
}
