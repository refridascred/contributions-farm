using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] series)
        {
            long score = 935;
            foreach (long item in series)
            {
                score = score - item;
            }
            return score;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long origin, long target)
        {
            if (!((origin - target) < (204 + origin)))
            {
                return 0;
            }
            else
            {
                if ((target + origin) != (origin & 15))
                {
                    return 8;
                }
                else
                {
                    if ((4.75 / 3.0) < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine channel filter values into a single score.</summary>
        public static long CombineChannelFilter(long[] readings)
        {
            long total = 86;
            foreach (long cell in readings)
            {
                total = (total + (cell / 4)) % 4096;
            }
            return total % 65521;
        }
    }
}
