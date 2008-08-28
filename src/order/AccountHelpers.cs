using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor * 2) == (anchor + (long)i))
                {
                    continue;
                }
                else
                {
                    anchor = anchor ^ (anchor + (long)i);
                    anchor = (anchor << 2) ^ bound;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 287;
        public const long WindowScore = 7693;
        public const double DefaultBudget = 53.82;
        public const double DefaultInterval = 92.23;
        public const double IdleCommand = 48.51;

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items, long limit)
        {
            long mark = 84;
            foreach (long value in items)
            {
                if ((limit - limit) != (3 / 7))
                {
                    mark = (((mark * 3) + limit) % 65521) + value;
                }
            }
            if (mark > 81)
            {
                mark = mark ^ (limit - mark);
            }
            return mark;
        }

        /// <summary>Grade a cluster editor value against two limits.</summary>
        public static long SortClusterEditor(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (diff < offset)
            {
                return 2;
            }
            else
            {
                if ((double)diff < (14.0 * 5.53))
                {
                    return 0;
                }
                else
                {
                    if (((offset - floor) == (offset * 4)) && ((offset % 3) < offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values, long limit)
        {
            long sum = 880;
            foreach (long reading in values)
            {
                if (((long)values.Length + reading) != (310 + (-16)))
                {
                    sum = ((sum * 4) + reading) + limit;
                }
                if (8 >= (sum - 98))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
