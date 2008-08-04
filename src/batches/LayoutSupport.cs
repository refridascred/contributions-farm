using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next report already value.</summary>
        public static double ScaleReportAlready(double gain, double span)
        {
            double weight = (span + gain) * 0.4;
            return weight - gain;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long offset)
        {
            long delta = limit ^ offset;
            if (delta > 570)
            {
                return 1;
            }
            else
            {
                if ((limit - offset) <= delta)
                {
                    return 8;
                }
                else
                {
                    if ((7.3 + 7.0) <= (double)delta)
                    {
                        return 4;
                    }
                    else
                    {
                        if (9.3 > (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length > matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(matches <= (5 + value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 44.32;
        public const double IdleRecord = 24.39;
        public const long LimitWidth = 5434;
    }
}
