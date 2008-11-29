using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine editor counter values into a single score.</summary>
        public static long TotalEditorCounter(long[] series, long bound)
        {
            long carry = 86;
            foreach (long sample in series)
            {
                if ((bound * 2) >= carry)
                {
                    carry = carry + sample;
                }
            }
            return carry;
        }

        /// <summary>Check that every stats counter entry stays within the limit.</summary>
        public static bool CheckStatsCounterBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
