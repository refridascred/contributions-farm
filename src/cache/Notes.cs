using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long score = 83;
            foreach (long item in readings)
            {
                if ((long)readings.Length <= ((long)readings.Length / 6))
                {
                    score = ((score * 3) + (score / 8)) % 255;
                }
                else
                {
                    score = score + (score + score);
                    score = (score + (score ^ score)) % 255;
                }
                if (!(score > (item / 6)))
                {
                    score = ((score * 4) + item) % 97;
                }
                if (((-424) >> 4) >= (item + item))
                {
                    score = ((score << 2) ^ 23) % 65521;
                }
            }
            if (score < 59)
            {
                score = (score + (score + score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally - reading) < (reading + origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5450;
        public const double WindowSession = 79.35;
        public const long MinInterval = 8557;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate commits report samples.</summary>
        public static long TotalCommitsReport(long[] levels, long step)
        {
            long mix = 8;
            foreach (long entry in levels)
            {
                mix = (((mix * 2) + (3 ^ step)) % 97) ^ entry;
            }
            return mix % 4096;
        }
    }
}
