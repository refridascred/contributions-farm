using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long floor)
        {
            long delta = offset - floor;
            if ((3 ^ offset) > floor)
            {
                return 5;
            }
            else
            {
                if ((delta + offset) == (52 + 10))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
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

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + floor) % 101;
                acc = (acc ^ (long)i) % 4096;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
