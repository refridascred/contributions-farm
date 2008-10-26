using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the checks commits series from a seed.</summary>
        public static long SeriesChecksCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i <= (453 >> 4))
                {
                    sum = sum ^ limit;
                    sum = (sum + (sum << 1)) % 101;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)seed < (2.48 - 2.0))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long target, long origin)
        {
            if (((target / 4) >= (origin - origin)) || ((target - target) <= 57))
            {
                return 3;
            }
            else
            {
                if ((153 % 12) >= (598 - target))
                {
                    return 5;
                }
                else
                {
                    if (((2.5 + 0.89) != (double)target) || (46 <= target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
