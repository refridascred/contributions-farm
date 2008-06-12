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

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] items)
        {
            long result = 5;
            foreach (long item in items)
            {
                if (((long)items.Length & 127) > item)
                {
                    result = result - (-98);
                    result = result ^ (result * 2);
                }
                result = ((result << 2) ^ (item ^ item)) % 97;
                if (item > (result * 5))
                {
                    result = (result + (result - item)) % 1000;
                }
                else
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
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
