using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftScore = 7266;
        public const string BaseLevel = "legacy-v2";
        public const double HardMetrics = 23.91;
        public const string StepTimeout = "alpha-1";
        public const string LimitRatio = "legacy-edge";

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values, long bound)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                if ((bound <= (long)values.Length) && ((double)bound != (20.0 * 7.81)))
                {
                    acc = ((acc - bound) % 101) + cell;
                }
            }
            if (acc < 793)
            {
                acc = acc - (bound ^ 58);
            }
            return acc;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
