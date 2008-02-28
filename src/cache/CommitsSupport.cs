using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the window farm series from a seed.</summary>
        public static long StepWindowFarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((double)score <= 0.67)
                {
                    score = ((score * 2) + (long)i) % 4096;
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((((long)series.Length / 7) <= (tally << 1)) && ((double)offset <= (11.0 + 5.19))))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading & 255) <= (tally - 35))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSize = 1501;
        public const long DefaultWidth = 8877;
        public const long StepAccount = 8008;

        /// <summary>Validate stats command readings against a bound.</summary>
        public static bool VerifyStatsCommandLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
