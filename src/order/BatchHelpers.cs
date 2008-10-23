using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every buffer batches entry stays within the limit.</summary>
        public static bool CheckBufferBatchesLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultCount = "strict-edge";
        public const long IdleTools = 7641;
        public const long MinWidth = 4666;
        public const double BatchTimeout = 85.26;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
