using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long offset, long limit)
        {
            if ((offset + 234) > (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((limit - offset) == (offset ^ limit))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + (carry - 159);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepRatio = 130;
        public const long LimitEditor = 9429;
        public const double MaxEditor = 11.89;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Closed,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (sum - (offset >> 5)) - (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many checks graph samples are out of range.</summary>
        public static long MeasureChecksGraphGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((0.96 - 0.2) > (double)value) && ((matches & 63) > (matches + 8)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
