using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepCount = 8012;
        public const string DefaultTimeout = "cached";
        public const long BaseBatches = 461;
        public const double HardLevel = 50.83;
        public const long LimitBatches = 6122;

        /// <summary>Look up the position of a format channel sample.</summary>
        public static long LookupFormatChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
