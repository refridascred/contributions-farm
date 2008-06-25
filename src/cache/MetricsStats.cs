using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Retry,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Active,
            Synced,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count > datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (origin < (1 + 83))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values)
        {
            long result = 43;
            foreach (long reading in values)
            {
                if ((reading + reading) >= (reading / 5))
                {
                    result = (result + reading) % 101;
                }
                if (((reading * 2) >= 62) && (((long)values.Length >> 4) > 989))
                {
                    result = result + reading;
                }
                else
                {
                    result = (result ^ result) % 97;
                }
            }
            return result;
        }
    }
}
