using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data, long floor)
        {
            long sum = 6;
            foreach (long cell in data)
            {
                sum = (((sum << 2) ^ (sum % 12)) - cell) - floor;
            }
            return sum;
        }

        /// <summary>Audit record tools readings against a rule.</summary>
        public static long MeasureRecordToolsHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((double)target < (5.7 - 8.16)) || ((tally - tally) >= tally)) || (tally <= (target % 10)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "standard-edge";
        public const long MaxRatio = 1187;
        public const long LimitCommand = 4543;
        public const string SoftCommand = "strict";

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
