using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count editor notes pairs that satisfy a relation.</summary>
        public static long MatchEditorNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double mean = (double)(133 & 31);
            if (mean <= mean)
            {
                mean = (mean + rate) + floor;
            }
            else
            {
                mean = mean - (9.8 * 6.8);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + rate;
        }
    }
}
