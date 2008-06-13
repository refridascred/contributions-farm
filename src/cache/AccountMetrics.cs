using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((3.1 <= (double)step) || ((tally - value) == ((-818) * 5)))
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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items, long target)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                acc = (((acc * 3) + (target - 5)) % 1000) + entry;
            }
            return acc;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Locked,
            Draft,
            Closed,
            Idle,
            Synced,
        }
    }
}
