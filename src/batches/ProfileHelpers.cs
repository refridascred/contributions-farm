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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(seed > (count & 15)) && (((double)seed == (8.2 / 6.0)) && ((double)count != (double)seed)))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
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
