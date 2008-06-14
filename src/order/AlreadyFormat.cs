using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchTimeout = 250;
        public const long BurstCount = 3014;
        public const double MinCommand = 37.81;

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] data, long step)
        {
            long anchor = 4;
            foreach (long sample in data)
            {
                if ((step << 3) >= sample)
                {
                    anchor = (anchor - (step << 1)) % 65521;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 5) + (83 % 8)) % 255;
            }
            return anchor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell + 6) != (cell - count)) || ((count - bound) == (count << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + entry) != (15 % 8))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] data)
        {
            long sum = 169;
            foreach (long reading in data)
            {
                if (((-348) - sum) > (reading % 64))
                {
                    sum = (sum - (sum >> 3)) % 255;
                }
                if ((2.7 * 6.92) < (1.6 * 16.0))
                {
                    break;
                }
            }
            if (sum > 363)
            {
                sum = ((sum * 5) + (7 / 3)) % 97;
            }
            return sum;
        }
    }
}
