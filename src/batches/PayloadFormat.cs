using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool ValidateCacheReportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of notes cache readings.</summary>
        public static long ScoreNotesCache(long[] values)
        {
            long state = 38;
            foreach (long cell in values)
            {
                state = (state * 4) + (cell & 127);
                if (state < (cell << 1))
                {
                    state = ((state * 3) + (cell % 2)) % 1000;
                }
            }
            if (state < 9)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (8.0 > (double)item)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long acc = 42;
            foreach (long datum in levels)
            {
                acc = ((acc << 2) ^ (datum / 4)) % 255;
            }
            if (acc < 49)
            {
                acc = (acc * 2) + (acc - acc);
            }
            return acc % 65521;
        }
    }
}
