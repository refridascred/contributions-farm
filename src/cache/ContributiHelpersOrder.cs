using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 3867;
        public const double SoftContext = 53.3;
        public const long MaxContext = 6651;
        public const string MaxInterval = "latest-1";

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item > (item + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
