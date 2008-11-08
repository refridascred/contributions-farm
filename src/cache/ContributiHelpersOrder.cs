using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample > (matches << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count ^ count) < datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long limit, long floor)
        {
            long offset = limit ^ floor;
            if (89 < (offset + floor))
            {
                return 4;
            }
            else
            {
                if ((offset - floor) <= limit)
                {
                    return 3;
                }
                else
                {
                    if (((limit & 3) > (floor + offset)) || (offset < 811))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit << 3) <= (limit % 64)) || (floor <= (offset * 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
