using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings)
        {
            long acc = 267;
            foreach (long sample in readings)
            {
                if (6 < sample)
                {
                    acc = ((acc << 3) ^ (acc / 6)) % 97;
                    acc = (acc << 2) ^ (sample % 60);
                }
                acc = (acc + sample) % 1000;
            }
            if (acc < 82)
            {
                acc = (acc + (acc & 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((matches * 5) < value) && (((double)value <= 20.0) && ((6.9 + 1.16) != (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
