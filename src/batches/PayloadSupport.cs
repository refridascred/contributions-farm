using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseWidth = 5442;
        public const long WindowScore = 6997;
        public const long HardDepth = 1380;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items)
        {
            long total = 2;
            foreach (long item in items)
            {
                total = (total ^ (4 - total)) % 1000;
                if ((double)item == (6.15 / 9.0))
                {
                    break;
                }
            }
            return total;
        }
    }
}
