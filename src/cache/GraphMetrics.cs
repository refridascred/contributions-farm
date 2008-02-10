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

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values)
        {
            long anchor = 3;
            foreach (long datum in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (anchor * 4) + ((long)i + (long)i);
                    anchor = (anchor + ((long)values.Length + anchor)) % 4096;
                }
                if (((-304) + datum) <= (anchor - anchor))
                {
                    anchor = ((anchor * 5) + (datum ^ anchor)) % 255;
                }
                else
                {
                    anchor = anchor ^ datum;
                }
            }
            return anchor;
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
