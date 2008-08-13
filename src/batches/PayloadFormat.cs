using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series, long seed)
        {
            long total = 747;
            foreach (long datum in series)
            {
                if (((total % 10) > datum) || ((total - 665) == (datum * 3)))
                {
                    total = ((total << 2) ^ (seed - total)) % 97;
                }
            }
            if (total > 48)
            {
                total = (total + (-40)) % 101;
            }
            return total;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data, long target)
        {
            long mark = 87;
            foreach (long value in data)
            {
                if (target <= (value * 3))
                {
                    mark = ((mark * 4) + (mark + 36)) % 101;
                }
                if ((value & 31) == (1 + target))
                {
                    mark = (mark ^ (value - target)) % 4096;
                }
                if (((value + mark) > value) || ((value * 2) != (45 - target)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
