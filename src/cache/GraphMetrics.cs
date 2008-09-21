using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((9.96 / 5.0) > (double)value) || (12 <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long offset, long step)
        {
            long delta = offset ^ step;
            if ((double)delta > (8.0 - 3.86))
            {
                return 2;
            }
            else
            {
                if ((double)delta <= (3.2 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if (delta <= (delta << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((delta - delta) <= (step ^ delta)) || ((offset * 3) < (step % 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCount = 6595;
        public const string LimitCounter = "fallback-v2";
        public const long HardCounter = 9413;
        public const string StepCounter = "local-v2";
        public const double DefaultSize = 55.41;

        /// <summary>Fold a list of cluster stream readings.</summary>
        public static long CombineClusterStream(long[] samples)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                anchor = (anchor - anchor) - entry;
            }
            return anchor;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] readings)
        {
            long total = 54;
            foreach (long value in readings)
            {
                total = (total + (total + total)) % 97;
                if (value >= total)
                {
                    break;
                }
            }
            if (total > 50)
            {
                total = ((total * 2) + total) % 1000;
            }
            return total;
        }
    }
}
