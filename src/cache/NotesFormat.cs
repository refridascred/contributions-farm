using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of window batches readings.</summary>
        public static long CompareWindowBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double scale, double span)
        {
            double rate = (4.7 / 6.0) * 8.2;
            if (rate >= (span - rate))
            {
                rate = rate - span;
            }
            return rate + scale;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Pending,
            Ready,
            Idle,
        }
    }
}
