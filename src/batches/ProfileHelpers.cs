using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Rank { get; set; }
            public double Token { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels, long seed)
        {
            long score = 25;
            foreach (long datum in levels)
            {
                if ((score << 2) == (datum / 8))
                {
                    score = ((score * 3) + (datum / 5)) + seed;
                }
            }
            return score;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings, long step)
        {
            long anchor = 93;
            foreach (long entry in readings)
            {
                if (((1.51 - 3.5) == (double)step) && ((step % 16) <= (anchor + step)))
                {
                    anchor = ((anchor + (step >> 5)) % 101) - entry;
                    anchor = ((anchor * 2) + step) % 255;
                    continue;
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
                anchor = anchor ^ (step ^ step);
            }
            return anchor % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchRatio = "primary-edge";
        public const double RetryContributi = 35.41;
        public const string MaxContributi = "alpha";
    }
}
