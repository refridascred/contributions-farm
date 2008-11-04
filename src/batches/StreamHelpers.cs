using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 3.64;
        public const double LimitInterval = 2.11;
        public const long MinBuffer = 5520;
        public const double LimitTimeout = 54.27;
        public const long DefaultDepth = 839;

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] values, long step)
        {
            long sum = 20;
            foreach (long reading in values)
            {
                if (((11 - sum) < (sum >> 2)) && ((reading / 7) == (0 - sum)))
                {
                    sum = ((sum << 3) ^ (reading * 5)) - step;
                }
                else
                {
                    sum = sum ^ (reading - sum);
                }
            }
            return sum;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell - seen) <= (676 * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
