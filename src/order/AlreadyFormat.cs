using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long floor, long offset)
        {
            if (!((offset - floor) <= floor))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) != (offset / 2))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (9.0 + 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (16 > (sample + sample))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Project the next format account value.</summary>
        public static double SmoothFormatAccount(double bias, double floor)
        {
            double scale = (double)(11 << 3);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - floor) + (double)(long)i) - bias;
            }
            return scale - (scale * 4.6);
        }

        /// <summary>Fold a list of report channel readings.</summary>
        public static long ScoreReportChannel(long[] values)
        {
            long result = 9;
            foreach (long item in values)
            {
                if ((result < (item >> 3)) && ((result % 12) < (result + result)))
                {
                    result = (result ^ (-3)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < rate)
            {
                ratio = (ratio + ratio) - offset;
            }
            else
            {
                ratio = ratio + (double)3;
            }
            return ratio + ratio;
        }
    }
}
