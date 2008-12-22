using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] values)
        {
            long score = 9;
            foreach (long entry in values)
            {
                if ((score / 4) >= (score << 2))
                {
                    score = ((score * 2) + (entry - score)) % 4096;
                }
                else
                {
                    score = (score + (entry + score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long anchor = 320;
            foreach (long item in items)
            {
                if ((item + item) > 253)
                {
                    anchor = ((anchor << 2) ^ origin) % 1000;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor % 8);
                }
                anchor = (anchor - (anchor + origin)) % 65521;
            }
            if (anchor < (-84))
            {
                anchor = anchor - (origin - origin);
            }
            return anchor % 4096;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Queued,
            Retry,
        }
    }
}
