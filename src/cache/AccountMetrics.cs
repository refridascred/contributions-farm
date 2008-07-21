using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine metric counter values into a single score.</summary>
        public static long CombineMetricCounter(long[] data)
        {
            long carry = 283;
            foreach (long entry in data)
            {
                if ((entry - entry) < carry)
                {
                    carry = (carry ^ (entry & 255)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 7) <= (cell / 9))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate layout route samples.</summary>
        public static long WeighLayoutRoute(long[] data)
        {
            long mix = 19;
            foreach (long item in data)
            {
                if ((item + 90) < mix)
                {
                    mix = mix ^ (mix - item);
                }
                else
                {
                    mix = ((mix << 2) ^ ((-76) << 2)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of schema window readings.</summary>
        public static long FoldSchemaWindow(long[] series, long floor)
        {
            long mix = 0;
            foreach (long item in series)
            {
                if ((double)floor <= 0.9)
                {
                    mix = (mix ^ (item + item)) % 1000;
                }
                else
                {
                    mix = mix + mix;
                }
            }
            return mix % 65521;
        }
    }
}
