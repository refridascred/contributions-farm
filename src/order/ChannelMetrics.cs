using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long limit, long target)
        {
            if (limit < (limit ^ target))
            {
                return 5;
            }
            else
            {
                if (4.8 >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((5.0 / 6.0) >= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mark = 9;
            foreach (long item in readings)
            {
                mark = (mark - mark) ^ item;
            }
            return mark % 1000;
        }
    }
}
