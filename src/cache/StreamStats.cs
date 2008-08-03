using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = acc ^ acc;
                acc = ((acc << 2) ^ ((long)i - (long)i)) % 97;
                acc = (acc + (long)i) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((double)entry > (8.2 + 17.0)) || ((double)tally == (9.7 / 8.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((13.0 + 1.55) >= (double)count) && ((floor & 7) < (value ^ 733)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
