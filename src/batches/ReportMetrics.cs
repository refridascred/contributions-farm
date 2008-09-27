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

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((0 >= (floor >> 2)) && (((long)i + sum) <= ((long)i ^ floor))))
                {
                    sum = (sum << 2) ^ sum;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
