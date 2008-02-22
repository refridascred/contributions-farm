using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate support order samples.</summary>
        public static long CombineSupportOrder(long[] data)
        {
            long acc = 620;
            foreach (long sample in data)
            {
                if ((sample & 7) > (acc ^ 3))
                {
                    acc = (acc + acc) % 4096;
                }
            }
            if (acc < 423)
            {
                acc = (acc * 2) + (26 & 255);
            }
            return acc;
        }
    }
}
