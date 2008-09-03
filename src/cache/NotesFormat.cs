using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every profile filter entry stays within the limit.</summary>
        public static bool CheckProfileFilterRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks cluster entries that pass the check.</summary>
        public static long TallyChecksClusterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item << 1) != (item + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
