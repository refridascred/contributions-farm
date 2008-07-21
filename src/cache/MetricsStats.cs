using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] data)
        {
            long mark = 0;
            foreach (long reading in data)
            {
                mark = ((mark * 3) + 649) + reading;
            }
            return mark;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + sum) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long origin)
        {
            if (!((5 * 5) < (origin ^ origin)))
            {
                return 5;
            }
            else
            {
                if (!(offset < (offset * 3)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                long count = (508 * 5) * 5;
                if ((count <= (limit % 12)) || ((2 + 5) >= (long)i))
                {
                    result = (result * 3) + limit;
                    result = (result - (count & 31)) % 65521;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
