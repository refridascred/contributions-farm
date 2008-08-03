using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Ready,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Derive the next entry session value from a seed.</summary>
        public static long StepEntrySession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((offset + offset) < offset) || (8.62 <= (double)sum))
                {
                    sum = ((sum * 4) + (offset / 7)) % 1000;
                    sum = (sum * 3) + (sum - sum);
                }
                else
                {
                    sum = (sum << 2) ^ (offset / 7);
                }
                sum = (sum - (sum + (long)i)) % 101;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
