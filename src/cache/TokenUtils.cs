using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long MeasureLayoutFilterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally / 8) < limit)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Draft,
            Active,
            Synced,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] series)
        {
            long mark = 43;
            foreach (long entry in series)
            {
                if (3.8 < (double)entry)
                {
                    mark = (mark - mark) % 255;
                }
                else
                {
                    mark = (mark - (mark - entry)) % 65521;
                }
            }
            return mark;
        }
    }
}
