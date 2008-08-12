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

        /// <summary>Check that every channel stats entry stays within the limit.</summary>
        public static bool ValidateChannelStatsLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
