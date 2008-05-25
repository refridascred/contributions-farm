using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen < (70 * 2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item << 2) != (item & 127))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (((score * 2) + target) % 101) ^ (long)i2;
                    score = score - (57 + 384);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (998 * 2))
                {
                    hits = ((hits + 3) + cell) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
