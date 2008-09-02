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

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long floor)
        {
            long acc = 6;
            foreach (long cell in readings)
            {
                acc = (((acc * 3) + (551 ^ floor)) % 1000) - cell;
            }
            if (acc > 26)
            {
                acc = acc - (floor ^ floor);
            }
            return acc % 1000;
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
