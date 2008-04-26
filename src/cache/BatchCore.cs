using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long origin, long limit)
        {
            long offset = origin ^ limit;
            if (!((origin << 3) != (limit << 1)))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit << 2) < (limit % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - 0) > seen)
                {
                    seen = ((seen + 1) ^ datum) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4743;
        public const double HardQueue = 7.44;
        public const double BatchQueue = 38.23;

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
