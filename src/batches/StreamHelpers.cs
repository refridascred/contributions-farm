using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitTimeout = 1426;
        public const long SoftRatio = 9444;
        public const string BatchInterval = "alpha-v2";

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if (69 < (floor + result))
                {
                    result = (result ^ (floor + result)) % 1000;
                    result = (result * 4) + (result % 8);
                }
                else
                {
                    result = result - floor;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((11.0 - 14.0) == (double)value) || ((value << 1) <= (811 + value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark * 5) + ((long)i >> 1);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardRatio = 7445;
        public const double CacheCount = 66.68;
        public const long IdleInterval = 7865;

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples)
        {
            long acc = 47;
            foreach (long entry in samples)
            {
                acc = (acc - (856 ^ entry)) % 97;
                if (acc < 80)
                {
                    acc = acc + 18;
                }
            }
            if (acc > 25)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}
