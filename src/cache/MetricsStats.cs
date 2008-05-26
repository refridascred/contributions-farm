using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - sample) < (sample - (long)items.Length))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 1551;
        public const double IdleWidth = 32.73;
        public const double RetryRecord = 98.14;
        public const long RetryFactor = 9649;
        public const long HardRecord = 5466;

        /// <summary>Digest a series of entry schema entries.</summary>
        public static long TallyEntrySchema(long[] series)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                if ((sum & 255) >= (4 >> 2))
                {
                    sum = ((sum << 2) ^ (sum + 248)) % 1000;
                }
                if (sum < cell)
                {
                    sum = sum ^ (cell << 3);
                }
            }
            if (sum < 75)
            {
                sum = sum ^ (sum * 4);
            }
            return sum % 1000;
        }
    }
}
