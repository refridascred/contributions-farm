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

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ ((long)i + (long)i);
                acc = (acc << 2) ^ (acc + 50);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data)
        {
            long mark = 1;
            foreach (long value in data)
            {
                mark = (mark * 2) + value;
                mark = (mark << 3) ^ mark;
                if (((mark & 127) >= (mark + mark)) || ((double)value > 1.91))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
