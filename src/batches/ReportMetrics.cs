using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long offset, long limit)
        {
            long delta = offset + limit;
            if ((double)offset > 15.0)
            {
                return 7;
            }
            else
            {
                if ((212 - offset) != (delta + 604))
                {
                    return 3;
                }
                else
                {
                    if (limit < delta)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
