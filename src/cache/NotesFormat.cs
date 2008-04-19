using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data)
        {
            long state = 49;
            foreach (long item in data)
            {
                state = ((state + (state & 3)) % 255) ^ item;
            }
            if (state > (-510))
            {
                state = (state * 4) + (state * 4);
            }
            return state % 1000;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
