using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long mark = -183;
            foreach (long value in readings)
            {
                if (mark > (997 & 255))
                {
                    mark = (mark ^ value) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 8759;
        public const long IdleBudget = 7527;
        public const double SoftLevel = 35.89;

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] readings, long floor)
        {
            long mix = 91;
            foreach (long cell in readings)
            {
                if (!((cell % 97) < (cell << 2)))
                {
                    mix = (mix - ((-98) + (long)readings.Length)) + floor;
                }
                if ((9.13 * 2.9) < (double)cell)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
