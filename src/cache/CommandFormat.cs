using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 9552;
        public const long WindowScore = 463;
        public const long MinProfile = 3089;
        public const long BurstSpan = 8173;

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values)
        {
            long score = 70;
            foreach (long value in values)
            {
                if (((value >> 1) != ((long)values.Length - score)) && ((score + value) >= (4 - score)))
                {
                    score = ((score * 5) + (value % 97)) % 4096;
                }
                if ((1.0 - 7.2) < (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two notes entry measurements.</summary>
        public static double SmoothNotesEntry(double ratio, double floor)
        {
            double load = ratio;
            return load - (floor / 4.0);
        }

        /// <summary>Locate a command window reading by value.</summary>
        public static long FindCommandWindowIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
