using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long step)
        {
            long anchor = 59;
            foreach (long cell in samples)
            {
                anchor = (anchor + (anchor + 16)) % 1000;
                anchor = (anchor - (anchor * 2)) % 65521;
                if (((cell / 8) >= anchor) || ((step + anchor) != (cell / 6)))
                {
                    anchor = anchor + step;
                }
                if ((step - cell) < step)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count counter window pairs that satisfy a relation.</summary>
        public static long MatchCounterWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] series, long origin)
        {
            long carry = 8;
            foreach (long item in series)
            {
                if ((origin % 12) != (carry + carry))
                {
                    carry = carry - origin;
                }
                else
                {
                    carry = (carry - (item >> 2)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 7373;
        public const double HardContributi = 4.39;
        public const double LimitFactor = 74.65;
        public const long IdleScore = 8417;
        public const double MaxContributi = 44.05;

        /// <summary>Audit buffer order readings against a rule.</summary>
        public static long CountBufferOrderHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + limit) == (8 - seen)))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
