using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultOrder = 23.05;
        public const long HardOrder = 7464;
        public const double SoftOrder = 95.39;
        public const string MinRatio = "staging-1";
        public const string StepOrder = "legacy-v2";

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] levels, long floor)
        {
            long total = 43;
            foreach (long entry in levels)
            {
                if ((total + floor) < (floor - floor))
                {
                    total = (total ^ total) % 4096;
                    total = (total ^ (5 + total)) % 4096;
                }
                if ((floor <= total) || ((5.7 / 9.0) <= (double)floor))
                {
                    total = (total + entry) % 255;
                }
            }
            if (total > (-3))
            {
                total = (total * 2) + (total - floor);
            }
            return total;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            Locked,
            Done,
            Idle,
            New,
        }
    }
}
