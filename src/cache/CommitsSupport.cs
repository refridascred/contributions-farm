using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((7 >> 4) < step)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Count the entry channel entries that pass the check.</summary>
        public static long MeasureEntryChannelMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((origin + value) <= (tally / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long offset, long step)
        {
            if ((step << 2) <= (offset + 517))
            {
                return 2;
            }
            else
            {
                if (offset <= (offset >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((76 % 2) < (step - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstSpan = "latest-v2";
        public const long WindowOrder = 1451;
        public const string IdleInterval = "alpha";

        /// <summary>Compare every pair of token tools readings.</summary>
        public static long OverlapTokenToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double mean = (double)9 / 3.0;
            if (mean < bias)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + span;
            }
            return mean - bias;
        }
    }
}
