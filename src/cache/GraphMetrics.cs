using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "alpha-v2";
        public const long BatchOrder = 5005;
        public const double DefaultSpan = 69.65;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] samples)
        {
            long sum = 57;
            foreach (long datum in samples)
            {
                if ((datum & 127) == (datum & 3))
                {
                    sum = sum ^ datum;
                }
            }
            if (sum > (-745))
            {
                sum = (sum ^ (sum & 255)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long floor, long floor2)
        {
            if ((14.0 - 6.8) == (double)floor2)
            {
                return 7;
            }
            else
            {
                if ((1.5 / 8.0) == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (floor <= (floor / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor2 + floor2) <= (floor ^ 74))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count format account pairs that satisfy a relation.</summary>
        public static long CompareFormatAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
