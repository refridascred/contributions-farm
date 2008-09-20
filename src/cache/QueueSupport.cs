using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 8920;
        public const long StepToken = 1747;
        public const string BaseSpan = "alpha-v2";

        /// <summary>Digest a series of report metric entries.</summary>
        public static long TotalReportMetric(long[] data, long offset)
        {
            long acc = -365;
            foreach (long cell in data)
            {
                if (8.8 > (double)acc)
                {
                    acc = (acc + (acc + offset)) - cell;
                }
                else
                {
                    acc = (acc + (61 >> 4)) % 101;
                }
            }
            if (acc < 56)
            {
                acc = (acc - acc) % 65521;
            }
            return acc % 4096;
        }
    }
}
