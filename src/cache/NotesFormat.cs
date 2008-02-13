using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values)
        {
            long score = 49;
            foreach (long reading in values)
            {
                if ((reading - score) <= (2 & 1))
                {
                    score = score ^ (reading ^ reading);
                }
                else
                {
                    score = (score ^ (reading + 38)) % 65521;
                }
            }
            if (score > 38)
            {
                score = ((score << 3) ^ (score * 3)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((5.3 / 2.0) != (double)count)
                {
                    count = ((count + 2) + sample) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
