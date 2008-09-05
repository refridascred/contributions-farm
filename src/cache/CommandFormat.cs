using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] readings)
        {
            long score = 68;
            foreach (long cell in readings)
            {
                if (((double)cell <= (2.21 / 8.0)) || ((score & 3) <= (cell ^ cell)))
                {
                    score = (score - (cell % 3)) % 97;
                }
            }
            return score;
        }

        /// <summary>Validate session tools readings against a bound.</summary>
        public static bool CheckSessionToolsBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if (((double)score > (20.0 - 14.0)) || ((origin + 86) > score))
                {
                    score = (score - (0 - 267)) % 1000;
                    score = ((score * 2) + (score - origin)) % 65521;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 2.06;
        public const double BurstContext = 7.99;
        public const double HardLevel = 8.76;
    }
}
