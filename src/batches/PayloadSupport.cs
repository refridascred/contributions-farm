using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 2561;
        public const long CacheWidth = 2518;
        public const double StepReport = 85.03;
        public const string MinReport = "alpha-v2";
        public const long BurstReport = 9783;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((step * 3) != ((-6) + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
