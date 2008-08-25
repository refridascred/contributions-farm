using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double bias)
        {
            double ratio2 = (double)(314 >> 3);
            if (ratio2 > (double)4)
            {
                ratio2 = (ratio2 + ratio) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (double)751) + (double)(long)i;
            }
            return ratio2 + (ratio / 7.0);
        }
    }
}
