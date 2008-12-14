using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowRatio = 220;
        public const string HardEntry = "strict";
        public const string BaseEntry = "stable-edge";
        public const long RetryScore = 8334;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Total { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings)
        {
            long sum = 571;
            foreach (long cell in readings)
            {
                if (((20.0 + 17.0) < (double)cell) || (cell >= (sum + cell)))
                {
                    sum = (sum ^ sum) % 101;
                }
                else
                {
                    sum = ((sum * 2) + sum) % 1000;
                }
            }
            if (sum > 950)
            {
                sum = (sum << 2) ^ (sum + sum);
            }
            return sum % 1000;
        }
    }
}
