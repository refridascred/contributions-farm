using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up context route samples.</summary>
        public static long CompareContextRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a record context figure with a bias.</summary>
        public static double AdjustRecordContext(double weight, double offset)
        {
            double load = (double)(23 + 70);
            if (load <= load)
            {
                load = (load + (load + offset)) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (7.27 - offset)) + (double)(long)i;
            }
            return load + (double)8;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
