using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of stats metric entries.</summary>
        public static long TallyStatsMetric(long[] values)
        {
            long result = -18;
            foreach (long value in values)
            {
                result = ((result * 4) + (value + (-1))) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long step)
        {
            long gap = origin - step;
            if ((8 + origin) == (step << 1))
            {
                return 7;
            }
            else
            {
                if ((step - 551) == (step - origin))
                {
                    return 2;
                }
                else
                {
                    if (!((7.08 * 7.52) < (double)gap))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.3 / 8.0) >= (12.0 - 3.5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values, long step)
        {
            long score = 89;
            foreach (long sample in values)
            {
                if ((sample + score) != (81 - 9))
                {
                    score = (score ^ (score / 2)) % 97;
                    score = (score ^ (step << 1)) % 101;
                }
                score = score + sample;
                if ((2 - score) >= (score & 7))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
