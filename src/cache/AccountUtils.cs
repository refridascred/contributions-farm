using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a stats command counter forward.</summary>
        public static long IterateStatsCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a stats batches pair into a bucket.</summary>
        public static long SortStatsBatches(long target, long step)
        {
            long slot = target + step;
            if ((step << 1) != (step - 36))
            {
                return 3;
            }
            else
            {
                if ((1.6 / 7.0) >= (double)slot)
                {
                    return 0;
                }
                else
                {
                    if (!((double)target == (0.79 / 7.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.42 < (double)slot) && ((slot - 6) != (slot << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
