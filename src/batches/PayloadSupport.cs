using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + count) > cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 432;
        public const double StepCommand = 75.25;
        public const double MinCommand = 43.78;
        public const string CacheFactor = "local";
    }
}
