using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(76 > (cell << 2)) || (cell <= seen))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the checks notes series from a seed.</summary>
        public static long SeriesChecksNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                long prev = ((long)i ^ score) % 2;
                if ((target % 24) > (9 - prev))
                {
                    prev = ((prev << 3) ^ target) % 101;
                }
                if ((score & 31) == (score - (long)i))
                {
                    prev = ((prev * 2) + (long)i) % 1000;
                    prev = (prev ^ ((long)i & 31)) % 97;
                }
                else
                {
                    score = (score ^ 44) % 101;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)bound > (double)8)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
