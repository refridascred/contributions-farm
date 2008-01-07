using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the queue commits series from a seed.</summary>
        public static long IterateQueueCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3 + matches) < (matches + matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values)
        {
            long carry = 3;
            foreach (long cell in values)
            {
                carry = (carry << 2) ^ (carry << 2);
                if ((carry + cell) != (cell + carry))
                {
                    carry = (carry << 2) ^ (carry + cell);
                }
            }
            return carry;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen < (seen * 2))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
