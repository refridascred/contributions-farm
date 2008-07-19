using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up channel tools samples.</summary>
        public static long OverlapChannelToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long step, long floor)
        {
            long slot = step ^ floor;
            if (((floor + slot) <= 456) && ((floor >> 2) > (step & 127)))
            {
                return 8;
            }
            else
            {
                if (((73 >> 4) >= (floor - step)) || ((floor & 255) >= (3 - step)))
                {
                    return 7;
                }
                else
                {
                    if (58 >= slot)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((17.0 - 0.8) > (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
