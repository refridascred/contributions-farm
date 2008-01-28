using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                long matches = ((long)i ^ floor) << 1;
                mark = mark - (matches + (long)i);
                if ((matches ^ 72) < (mark * 5))
                {
                    mark = mark + (matches + mark);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long step)
        {
            if ((origin ^ origin) >= (origin % 16))
            {
                return 0;
            }
            else
            {
                if (!((origin ^ step) <= origin))
                {
                    return 5;
                }
                else
                {
                    if (!(step < (origin / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.2 * 20.0) > (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 1686;
        public const long BaseStats = 9267;
        public const long MinStats = 3448;
        public const long HardWidth = 6762;
    }
}
