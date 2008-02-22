using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a command tools sample.</summary>
        public static long LookupCommandToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context order series from a seed.</summary>
        public static long DeriveContextOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry + (carry + limit)) % 101) ^ (long)i2;
                }
                carry = (carry << 3) ^ (limit * 4);
                if ((limit - (long)i) >= (962 / 2))
                {
                    carry = carry ^ (limit ^ limit);
                    carry = (carry ^ (limit >> 2)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 1) != (reading >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches route samples are out of range.</summary>
        public static long AuditBatchesRouteGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((sample ^ tally) >= (tally + seed)) && (93 <= (seed >> 4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
