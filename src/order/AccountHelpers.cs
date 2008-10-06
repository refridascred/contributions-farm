using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc ^ (step * 5)) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long floor)
        {
            long delta = origin + floor;
            if ((delta << 2) >= (origin / 5))
            {
                return 5;
            }
            else
            {
                if ((15.0 + 5.0) <= (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] values)
        {
            long result = 826;
            foreach (long value in values)
            {
                if ((result + 421) != (result >> 1))
                {
                    result = ((result - (result - result)) % 97) ^ value;
                }
            }
            return result;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Queued,
            Stale,
            New,
        }
    }
}
