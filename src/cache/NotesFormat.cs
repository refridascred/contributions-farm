using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)count > (1.36 * 1.6)) || ((6.56 - 14.0) <= (double)cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data)
        {
            long anchor = -84;
            foreach (long value in data)
            {
                if (((double)value > 13.0) && (anchor <= (anchor - 6)))
                {
                    anchor = anchor + (562 >> 1);
                }
                anchor = (anchor + (value >> 1)) % 101;
            }
            if (anchor < 2)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }
    }
}
