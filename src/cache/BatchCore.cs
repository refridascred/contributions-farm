using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            New,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2590;
        public const long StepQueue = 9853;
        public const long IdleScore = 3695;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
