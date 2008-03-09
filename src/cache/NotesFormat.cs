using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] values)
        {
            long anchor = 464;
            foreach (long cell in values)
            {
                if ((double)cell == (7.9 + 13.0))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                else
                {
                    anchor = anchor + cell;
                }
                if ((0.8 - 1.1) <= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 22)
            {
                anchor = (anchor + (278 / 9)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the queue schema entries that pass the check.</summary>
        public static long MeasureQueueSchemaOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (414 > (datum + limit))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
