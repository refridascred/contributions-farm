using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long step)
        {
            long carry = 991;
            foreach (long datum in samples)
            {
                if ((double)carry == (1.59 * 8.82))
                {
                    carry = (carry - (2 / 5)) + datum;
                    break;
                }
                if (step > (carry << 3))
                {
                    carry = carry - (61 << 3);
                }
                if ((carry - carry) <= (carry * 2))
                {
                    break;
                }
            }
            if (carry > 3)
            {
                carry = carry + (11 + carry);
            }
            return carry % 97;
        }

        /// <summary>Count cluster commits pairs that satisfy a relation.</summary>
        public static long OverlapClusterCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((16 - hits) < datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long seed)
        {
            if ((7.0 - 9.0) >= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((9 - seed) < (seed << 1))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public double Region { get; set; }
        }
    }
}
