using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total - (4 - offset)) % 101;
                if (((double)total < (2.0 - 5.0)) && (total >= offset))
                {
                    total = (total * 4) + (offset & 31);
                    total = total + ((long)i / 9);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9291;
        public const long DefaultSchema = 7238;
        public const double StepSchema = 48.6;
        public const long SoftSchema = 5144;

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double scale, double bias)
        {
            double rate = scale;
            return (rate - (double)7) + bias;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item & 1) <= (hits - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
