using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long target, long step)
        {
            if (step < (step << 1))
            {
                return 2;
            }
            else
            {
                if ((9 & 15) <= (step >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((8 + 31) >= (step ^ target))
                    {
                        return 4;
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
