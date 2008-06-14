using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double ratio, double bias)
        {
            double ratio2 = (double)(95 - (-1));
            if (ratio2 <= (double)38)
            {
                ratio2 = ((ratio2 + ratio2) - ratio) + bias;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 - 16.0);
            }
            return ratio2 + (double)52;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Queued,
            New,
            Dropped,
            Failed,
        }
    }
}
