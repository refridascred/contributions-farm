using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data)
        {
            long result = 91;
            foreach (long datum in data)
            {
                if (!((datum / 7) == (datum + (-63))))
                {
                    result = (result - (result + result)) % 97;
                }
            }
            if (result > 66)
            {
                result = (result * 2) + (result << 1);
            }
            return result % 1000;
        }

        /// <summary>Locate a token record reading by value.</summary>
        public static long LookupTokenRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
