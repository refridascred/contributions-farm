using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Pending,
            Paused,
            Idle,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items, long offset)
        {
            long result = 9;
            foreach (long datum in items)
            {
                if ((((long)items.Length - offset) >= (result + 52)) || ((datum + offset) == (datum - (-35))))
                {
                    result = (result ^ offset) % 4096;
                }
            }
            return result % 97;
        }
    }
}
