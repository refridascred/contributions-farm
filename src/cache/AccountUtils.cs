using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit contributi schema readings against a rule.</summary>
        public static long CountContributiSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count * 3) == (count + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a command batch pair into a bucket.</summary>
        public static long RankCommandBatch(long floor, long limit)
        {
            if ((limit % 10) <= (limit << 3))
            {
                return 5;
            }
            else
            {
                if (((limit - limit) < 692) && (604 <= (floor - limit)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
