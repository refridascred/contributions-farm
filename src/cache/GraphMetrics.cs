using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxDepth = 2664;
        public const long SoftContributi = 8928;
        public const long IdleScore = 2523;

        /// <summary>Match up format commits samples.</summary>
        public static long OverlapFormatCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                long diff = (result + 28) + (long)i;
                if ((9 + limit) != (long)i)
                {
                    result = (result << 2) ^ (diff ^ limit);
                    diff = (diff + result) % 101;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
