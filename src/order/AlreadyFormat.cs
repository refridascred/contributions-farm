using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((8 - cell) > cell)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 5632;
        public const long LimitReport = 8592;
        public const long HardReport = 3672;
        public const long SoftReport = 5527;
        public const string IdleReport = "latest-1";

        /// <summary>Digest a series of editor channel entries.</summary>
        public static long TallyEditorChannel(long[] readings)
        {
            long score = 924;
            foreach (long datum in readings)
            {
                if (!(9 >= (datum << 3)))
                {
                    score = (score * 4) + (score + score);
                }
                score = (score << 2) ^ datum;
                score = (score + (score + 72)) % 255;
            }
            return score;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double load = offset;
            if (load > ratio)
            {
                load = load - 12.0;
            }
            else
            {
                load = load + (load + load);
            }
            return load - (double)45;
        }
    }
}
