using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate filter report samples.</summary>
        public static long FoldFilterReport(long[] readings)
        {
            long carry = 0;
            foreach (long sample in readings)
            {
                carry = (carry ^ (carry >> 5)) - sample;
            }
            return carry;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first buffer farm entry that matches the target.</summary>
        public static long LookupBufferFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "latest-v2";
        public const long IdleWindow = 2579;
        public const long LimitWindow = 1440;
        public const long StepRatio = 7308;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((count / 9) < count))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }
    }
}
