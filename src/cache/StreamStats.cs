using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long limit2)
        {
            if (!((limit - limit) < limit2))
            {
                return 3;
            }
            else
            {
                if ((limit2 <= (limit2 & 63)) && ((double)limit2 > 6.4))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit2 == (10.0 - 3.4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((572 & 3) < (limit + 5)) || ((0.71 - 2.4) == (double)limit2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - matches) < datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 11.26;
        public const double LimitStats = 80.16;
        public const double WindowStats = 14.79;
        public const long MaxStats = 4515;
    }
}
