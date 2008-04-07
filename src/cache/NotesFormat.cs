using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
