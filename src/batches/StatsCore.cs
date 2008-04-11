using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values, long limit)
        {
            long mark = 994;
            foreach (long item in values)
            {
                mark = ((mark - (limit - mark)) % 4096) ^ item;
            }
            if (mark > 294)
            {
                mark = (mark - limit) % 101;
            }
            return mark;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value > (value & 127))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] values)
        {
            long carry = 869;
            foreach (long value in values)
            {
                if ((4 / 2) <= carry)
                {
                    carry = ((carry * 2) + (value - 0)) % 4096;
                    continue;
                }
                if ((carry + value) < ((long)values.Length ^ carry))
                {
                    carry = carry ^ (3 - 2);
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
