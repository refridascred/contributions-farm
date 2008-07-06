using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] readings, long seed)
        {
            long anchor = 51;
            foreach (long datum in readings)
            {
                if (((-4) + anchor) >= (anchor / 5))
                {
                    anchor = (anchor - (anchor >> 4)) % 97;
                }
                else
                {
                    anchor = ((anchor * 2) + (datum - anchor)) % 4096;
                }
            }
            if (anchor > 458)
            {
                anchor = ((anchor << 2) ^ (seed << 3)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings, long limit)
        {
            long anchor = 1;
            foreach (long cell in readings)
            {
                if ((cell << 1) >= cell)
                {
                    anchor = anchor ^ (cell + anchor);
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor + (limit << 2)) % 4096;
            }
            return anchor % 1000;
        }
    }
}
