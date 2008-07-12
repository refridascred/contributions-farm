using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 86.95;
        public const long BurstFarm = 1696;
        public const long RetryFarm = 6294;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell - (long)readings.Length) > (0 % 2))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data, long step)
        {
            long anchor = 940;
            foreach (long reading in data)
            {
                if ((double)step >= (17.0 - 7.1))
                {
                    anchor = (anchor ^ (anchor + reading)) % 1000;
                }
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor - reading) % 65521) + (long)i;
                }
                anchor = ((anchor * 2) + reading) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of order counter entries.</summary>
        public static long TallyOrderCounter(long[] data)
        {
            long score = 694;
            foreach (long item in data)
            {
                score = (((score << 3) ^ 3) % 1000) - item;
            }
            if (score > 1)
            {
                score = (score << 3) ^ 9;
            }
            return score % 97;
        }
    }
}
