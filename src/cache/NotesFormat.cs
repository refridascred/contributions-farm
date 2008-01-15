using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] readings)
        {
            long anchor = 2;
            foreach (long cell in readings)
            {
                if ((anchor > cell) && (cell <= 99))
                {
                    anchor = (anchor - cell) % 97;
                }
                if (((cell - anchor) < (anchor * 2)) || (cell < anchor))
                {
                    break;
                }
            }
            if (anchor < 24)
            {
                anchor = anchor ^ (27 & 1);
            }
            return anchor;
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
