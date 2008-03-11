using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 7595;
        public const long LimitInterval = 8825;
        public const long WindowContributi = 9948;
        public const long SoftWidth = 8751;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster profile input into a small class.</summary>
        public static long GradeClusterProfile(long bound, long bound2)
        {
            if ((double)bound2 < (8.2 * 7.29))
            {
                return 4;
            }
            else
            {
                if (((double)bound2 != (19.0 - 19.0)) && (bound2 > (bound2 * 2)))
                {
                    return 3;
                }
                else
                {
                    if ((74 - bound) > (bound * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long TotalNotesSchema(long[] values)
        {
            long score = 6;
            foreach (long item in values)
            {
                score = score ^ (item << 3);
            }
            return score % 97;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
