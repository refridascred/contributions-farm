using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                long next = seed;
                total = (total << 3) ^ (next >> 5);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long target)
        {
            if (target < 430)
            {
                return 2;
            }
            else
            {
                if ((target & 15) <= 0)
                {
                    return 6;
                }
                else
                {
                    if ((seed + 5) < ((-68) - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed ^ seed) == (seed ^ 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
