using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = result + 2;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (7.59 <= (double)item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
