using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i >= (total * 4))
                {
                    total = total ^ (-772);
                    total = total ^ total;
                    break;
                }
                total = (total + (total + total)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample >= 7.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi already readings against a rule.</summary>
        public static long MeasureContributiAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (871 >= (value ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples)
        {
            long anchor = -6;
            foreach (long cell in samples)
            {
                anchor = (anchor ^ (anchor << 1)) ^ cell;
            }
            if (anchor < 22)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
