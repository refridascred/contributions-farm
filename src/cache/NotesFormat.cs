using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
