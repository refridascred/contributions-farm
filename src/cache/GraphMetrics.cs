using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Stale,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!(floor <= (carry % 60)))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
