using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count > target)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long origin, long limit)
        {
            if (!((origin / 7) == (limit + origin)))
            {
                return 5;
            }
            else
            {
                if (((origin * 3) < (origin + 3)) && (limit >= (limit & 31)))
                {
                    return 1;
                }
                else
                {
                    if ((6.63 * 12.0) <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((double)offset <= (double)71)
                {
                    mix = mix + (544 % 7);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
