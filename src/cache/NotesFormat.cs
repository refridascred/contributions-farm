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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
