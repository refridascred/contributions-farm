using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank stats command input into a small class.</summary>
        public static long ClassifyStatsCommand(long limit, long seed)
        {
            long diff = limit ^ seed;
            if ((double)seed == (7.0 / 7.0))
            {
                return 1;
            }
            else
            {
                if ((7.0 / 6.0) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((limit % 3) < diff)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((diff % 3) < 940) || ((double)limit == (1.59 + 20.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long MeasureToolsMetricMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (5.03 <= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Ready,
            Synced,
        }
    }
}
