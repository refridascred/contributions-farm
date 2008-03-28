using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank editor stream input into a small class.</summary>
        public static long SortEditorStream(long bound, long bound2)
        {
            long lane = bound - bound2;
            if ((2.5 / 2.0) <= (double)lane)
            {
                return 1;
            }
            else
            {
                if ((bound2 / 2) == (11 * 5))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the buffer command entries that pass the check.</summary>
        public static long TallyBufferCommandMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((target / 7) <= (64 + 7))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ (204 << 2)) % 1000;
                long cur = total;
                if ((6.47 / 6.0) >= (double)total)
                {
                    total = total - (cur + step);
                    cur = cur ^ (long)i;
                    continue;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
