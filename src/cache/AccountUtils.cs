using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next context graph value from a seed.</summary>
        public static long IterateContextGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                long matches = ((long)i & 31) * 2;
                sum = sum - matches;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
