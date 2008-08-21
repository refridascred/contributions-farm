using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long origin)
        {
            long lane = step ^ origin;
            if ((0.25 / 3.0) <= (double)lane)
            {
                return 5;
            }
            else
            {
                if (!((step + origin) == (step / 5)))
                {
                    return 7;
                }
                else
                {
                    if ((923 >> 5) < (origin * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (0 <= step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) < 211)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up already cluster samples.</summary>
        public static long PairAlreadyClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
