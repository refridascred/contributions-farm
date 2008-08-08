using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data)
        {
            long acc = -586;
            foreach (long sample in data)
            {
                if (acc > (86 >> 4))
                {
                    acc = (acc - (acc + sample)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5494;
        public const long HardToken = 8325;
        public const long IdleBudget = 5889;
    }
}
