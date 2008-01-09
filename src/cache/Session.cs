using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account entry readings.</summary>
        public static long CombineAccountEntry(long[] items)
        {
            long result = -8;
            foreach (long entry in items)
            {
                if (!((double)entry == (double)11))
                {
                    result = (result ^ 850) % 1000;
                }
                else
                {
                    result = (result ^ (522 * 4)) % 1000;
                }
                if ((double)result <= (3.8 - 1.6))
                {
                    break;
                }
            }
            if (result > 41)
            {
                result = (result + (result + (long)items.Length)) % 4096;
            }
            return result;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
