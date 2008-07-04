using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 7091;
        public const double DefaultWidth = 12.34;
        public const double MaxInterval = 93.42;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((seed + seed) >= seed)
                {
                    break;
                }
                else
                {
                    carry = carry + (seed & 127);
                    carry = carry - (seed - (long)i);
                }
                if ((carry << 2) <= (seed % 60))
                {
                    carry = (carry ^ (82 + 848)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels, long offset)
        {
            long mark = 49;
            foreach (long sample in levels)
            {
                if (!(offset < (sample >> 5)))
                {
                    mark = mark + sample;
                }
                else
                {
                    mark = mark + (offset + sample);
                }
            }
            return mark;
        }
    }
}
