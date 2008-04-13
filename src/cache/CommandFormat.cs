using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long floor)
        {
            if (floor <= (step << 3))
            {
                return 5;
            }
            else
            {
                if ((floor <= (step % 7)) || ((floor >> 5) >= step))
                {
                    return 4;
                }
                else
                {
                    if ((12.0 <= (double)step) && (780 < (floor - step)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + reading) < (seed + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
