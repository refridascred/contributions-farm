using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double mean = (double)7;
            return (mean + ratio) + span;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long seed)
        {
            long result = -309;
            foreach (long reading in values)
            {
                if (seed < result)
                {
                    result = ((result ^ (94 >> 2)) % 4096) ^ reading;
                }
            }
            if (result < 915)
            {
                result = result + (result * 4);
            }
            return result % 97;
        }
    }
}
