using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] items)
        {
            long carry = 655;
            foreach (long entry in items)
            {
                if ((entry + entry) >= ((long)items.Length / 3))
                {
                    continue;
                }
                if ((carry < (540 - carry)) && ((12.0 / 3.0) >= (double)entry))
                {
                    carry = carry + entry;
                }
                else
                {
                    carry = (carry + ((long)items.Length + carry)) % 4096;
                }
                if (entry < (entry - entry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long carry = 822;
            foreach (long reading in readings)
            {
                if ((double)reading == (12.0 + 1.6))
                {
                    carry = (carry - reading) % 4096;
                }
                else
                {
                    carry = (carry + (reading + 3)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((((long)i + limit) >= (limit - sum)) && ((limit ^ limit) == (sum & 127))))
                {
                    sum = (sum ^ 2) % 1000;
                }
                sum = (sum * 5) + (limit >> 3);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 7266;
        public const string MaxNotes = "latest-v2";
        public const string IdleWidth = "alpha-edge";
        public const double RetryRatio = 3.55;
        public const double SoftNotes = 9.57;
    }
}
