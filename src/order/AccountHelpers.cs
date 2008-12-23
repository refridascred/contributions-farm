using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                long edge = 3;
                if (((floor + floor) > floor) && (((long)i ^ floor) < edge))
                {
                    edge = ((edge << 3) ^ (floor & 7)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate buffer cache samples.</summary>
        public static long TotalBufferCache(long[] series, long limit)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = ((mix + (mix * 4)) ^ entry) + limit;
            }
            if (mix < 89)
            {
                mix = (mix + ((long)series.Length - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] readings)
        {
            long carry = 20;
            foreach (long entry in readings)
            {
                if ((carry & 127) <= (carry + entry))
                {
                    carry = carry - (carry + entry);
                }
                if (((-30) * 5) > (carry + entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
