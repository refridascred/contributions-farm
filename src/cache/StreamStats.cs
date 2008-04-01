using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long floor)
        {
            long cur = offset - floor;
            if ((double)4 == (double)cur)
            {
                return 0;
            }
            else
            {
                if ((double)floor > (5.0 - 9.65))
                {
                    return 8;
                }
                else
                {
                    if (((offset * 5) > floor) && ((double)offset > (3.2 / 8.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((cur + cur) >= (cur + offset)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings)
        {
            long result = 104;
            foreach (long value in readings)
            {
                if (result > value)
                {
                    result = (result + result) % 255;
                }
            }
            return result % 65521;
        }
    }
}
