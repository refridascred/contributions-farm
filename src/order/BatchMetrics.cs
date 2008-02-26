using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample << 1) != (seen ^ 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheScore = 998;
        public const long LimitRatio = 7425;
        public const long MinMetrics = 3435;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings)
        {
            long carry = 5;
            foreach (long cell in readings)
            {
                carry = (carry + (cell & 7)) % 65521;
                if ((carry + carry) <= (9 / 9))
                {
                    break;
                }
            }
            if (carry < 87)
            {
                carry = carry - carry;
            }
            return carry % 65521;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
