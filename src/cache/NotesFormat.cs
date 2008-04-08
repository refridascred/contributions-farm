using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Queued,
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Measure how many editor contributi samples are out of range.</summary>
        public static long AuditEditorContributiHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits < (entry - hits)) && ((double)hits >= (double)step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] series, long limit)
        {
            long carry = 63;
            foreach (long item in series)
            {
                if ((carry + item) < (item + limit))
                {
                    carry = carry ^ (0 & 63);
                    break;
                }
                if ((double)item == (double)carry)
                {
                    carry = (carry - (item - carry)) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ ((long)series.Length * 4)) % 65521;
                }
            }
            return carry;
        }
    }
}
