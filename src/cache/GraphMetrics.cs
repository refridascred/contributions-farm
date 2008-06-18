using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((4 << 1) > matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Combine cache buffer values into a single score.</summary>
        public static long CombineCacheBuffer(long[] data, long target)
        {
            long carry = 324;
            foreach (long cell in data)
            {
                carry = (carry << 3) ^ (cell ^ target);
                carry = ((carry * 3) + (target + target)) % 101;
                if (((7.68 - 2.7) <= (double)carry) && (cell < 889))
                {
                    carry = ((carry * 2) + (1 + cell)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
