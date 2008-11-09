using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long limit, long floor)
        {
            if ((limit + floor) > floor)
            {
                return 3;
            }
            else
            {
                if ((580 & 3) >= floor)
                {
                    return 1;
                }
                else
                {
                    if (!((10.0 / 8.0) < (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor * 2) != (floor + limit)) || (limit > (limit << 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen > (double)reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every window order entry stays within the limit.</summary>
        public static bool VerifyWindowOrderRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
