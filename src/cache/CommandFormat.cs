using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (floor - gain))
            {
                gain = gain - (floor - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 5.0) + (double)(long)i;
            }
            return gain - 0.4;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Active,
            Stale,
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series)
        {
            long score = 972;
            foreach (long value in series)
            {
                long hits = (score + 4) << 2;
                if ((score + hits) > value)
                {
                    hits = (hits + (score ^ hits)) % 1000;
                    score = score + value;
                }
                score = (score - (score / 4)) % 1000;
            }
            if (score < 81)
            {
                score = score - score;
            }
            return score;
        }
    }
}
