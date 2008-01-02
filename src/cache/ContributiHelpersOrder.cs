using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank cluster entry input into a small class.</summary>
        public static long BucketClusterEntry(long target, long offset)
        {
            if ((offset + target) < target)
            {
                return 5;
            }
            else
            {
                if (((offset & 31) >= offset) || ((offset ^ offset) <= (offset / 6)))
                {
                    return 7;
                }
                else
                {
                    if ((4 - 500) != (offset + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 4) <= target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] series)
        {
            long sum = 298;
            foreach (long datum in series)
            {
                sum = (((sum << 2) ^ ((long)series.Length & 3)) % 97) - datum;
            }
            return sum;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
