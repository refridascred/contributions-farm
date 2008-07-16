using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long floor, long limit)
        {
            if (floor > 32)
            {
                return 3;
            }
            else
            {
                if ((limit << 1) == (floor - limit))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 / 5.0) <= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((431 + reading) < (-159))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
