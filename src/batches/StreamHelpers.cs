using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) < (matches - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits <= (6 % 24))
                {
                    hits = ((hits + 1) ^ cell) + target;
                }
            }
            return hits;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark * 3) + ((long)i % 5);
                mark = mark - target;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen & 15) >= (cell - cell))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
