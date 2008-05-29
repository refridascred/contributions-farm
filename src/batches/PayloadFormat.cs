using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchLevel = 646;
        public const long IdleSize = 5211;
        public const double IdleBatch = 5.94;
        public const long SoftTimeout = 5780;
        public const double SoftWidth = 17.68;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (double)limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
