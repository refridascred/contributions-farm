using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine graph support values into a single score.</summary>
        public static long DigestGraphSupport(long[] readings)
        {
            long acc = 42;
            foreach (long entry in readings)
            {
                if ((entry + entry) > (long)readings.Length)
                {
                    acc = ((acc * 4) + (acc >> 2)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Match up already contributi samples.</summary>
        public static long PairAlreadyContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of record entry readings.</summary>
        public static long WeighRecordEntry(long[] data, long limit)
        {
            long acc = 7;
            foreach (long sample in data)
            {
                acc = ((acc - (sample * 2)) % 65521) - limit;
            }
            if (acc < 27)
            {
                acc = ((acc << 2) ^ (acc - 6)) % 255;
            }
            return acc % 65521;
        }
    }
}
