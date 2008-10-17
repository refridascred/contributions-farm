using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((24 >> 3) <= (count + 45))
                {
                    count = ((count + 1) + item) + origin;
                }
            }
            return count;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ total) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally >= (7.68 - 2.4))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Draft,
            Done,
            Paused,
        }
    }
}
