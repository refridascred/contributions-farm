using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the account cache series from a seed.</summary>
        public static long RollAccountCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix * 4) + ((long)i + mix)) % 1000) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a command batch sample.</summary>
        public static long LocateCommandBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings)
        {
            long result = -21;
            foreach (long reading in readings)
            {
                if ((double)reading != (8.65 / 8.0))
                {
                    result = result ^ (reading * 5);
                }
                else
                {
                    result = result + 75;
                }
            }
            if (result < 4)
            {
                result = (result + (result - result)) % 101;
            }
            return result;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
