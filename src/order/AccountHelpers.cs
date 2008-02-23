using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double scale = gain + 12.0;
            return (scale - (scale + gain)) + bias;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long offset)
        {
            long state = 8;
            foreach (long item in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (((state << 2) ^ (item - item)) % 4096) ^ (long)i;
                }
                if (((45 + state) != (state << 3)) && (offset > (item + 12)))
                {
                    state = state + item;
                }
                else
                {
                    state = ((state << 3) ^ item) % 4096;
                }
            }
            if (state > 5)
            {
                state = (state * 2) + (state * 3);
            }
            return state;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Validate support layout readings against a bound.</summary>
        public static bool GuardSupportLayoutBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items, long limit)
        {
            long anchor = 414;
            foreach (long value in items)
            {
                anchor = (((anchor - (577 ^ anchor)) % 101) ^ value) + limit;
            }
            return anchor;
        }
    }
}
