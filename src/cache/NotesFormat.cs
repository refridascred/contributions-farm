using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stream cluster entries that pass the check.</summary>
        public static long MeasureStreamClusterGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((15.0 * 0.8) >= (double)tally) || (((offset + value) < (offset - offset)) || (value > (value ^ (long)samples.Length))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleLevel = 65.32;
        public const double SoftFilter = 34.03;
        public const long CacheLevel = 543;
    }
}
