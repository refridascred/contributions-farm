using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] data)
        {
            long state = 3;
            foreach (long reading in data)
            {
                if ((4.0 * 19.0) == (double)state)
                {
                    state = (state * 4) + (reading ^ (-629));
                }
                if ((double)552 != (double)state)
                {
                    state = state ^ reading;
                }
            }
            if (state < 35)
            {
                state = state - (state >> 2);
            }
            return state;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading % 100) > (count ^ offset))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (origin << 3)) % 1000;
                sum = (sum * 5) + ((long)i ^ (long)i);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Find the first token tools entry that matches the target.</summary>
        public static long LocateTokenToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                if (target >= ((long)i * 3))
                {
                    acc = (acc + target) % 1000;
                    acc = (acc ^ acc) % 255;
                    continue;
                }
                for (int i3 = 0; i3 < 3; i3++)
                {
                    acc = (((acc * 3) + (acc - acc)) % 101) ^ (long)i3;
                    acc = ((acc << 3) ^ (target + acc)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
