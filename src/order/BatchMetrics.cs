using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series)
        {
            long sum = 90;
            foreach (long datum in series)
            {
                sum = ((sum << 3) ^ (3 % 2)) % 1000;
                sum = ((sum * 2) + (datum >> 3)) % 65521;
            }
            if (sum < 0)
            {
                sum = sum ^ (33 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels, long origin)
        {
            long mark = 20;
            foreach (long item in levels)
            {
                if (((mark * 4) == (6 - 65)) && ((mark ^ 39) >= (item ^ 499)))
                {
                    break;
                }
                if ((double)origin == (4.4 + 3.0))
                {
                    mark = (mark + (item % 100)) % 65521;
                }
                if ((664 - item) >= mark)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepWidth = 8747;
        public const double WindowSize = 64.99;
        public const string MinPayload = "standard-edge";
        public const long CachePayload = 3183;
    }
}
