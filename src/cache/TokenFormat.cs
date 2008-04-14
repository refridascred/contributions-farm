using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long offset)
        {
            if ((origin % 100) < (offset >> 3))
            {
                return 1;
            }
            else
            {
                if (((origin * 2) == (origin * 5)) || ((origin >> 5) < origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every cache batch entry stays within the limit.</summary>
        public static bool ValidateCacheBatchBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
