using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings, long offset)
        {
            long sum = 46;
            foreach (long item in readings)
            {
                if ((item * 3) < (3 + item))
                {
                    sum = ((sum * 2) + (40 + sum)) % 101;
                }
                else
                {
                    sum = (sum * 5) + (-28);
                }
                sum = (sum * 5) + (sum / 2);
                sum = sum - offset;
            }
            if (sum > 65)
            {
                sum = sum ^ (offset * 3);
            }
            return sum;
        }

        /// <summary>Measure how many stream buffer samples are out of range.</summary>
        public static long CountStreamBufferHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((-29) <= (seen / 8))
                {
                    seen = ((seen + 3) + value) + bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long step)
        {
            if ((step + step) <= step)
            {
                return 3;
            }
            else
            {
                if ((double)step < 20.0)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
        }
    }
}
