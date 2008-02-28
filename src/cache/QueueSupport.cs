using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long offset, long limit)
        {
            long slot = offset + limit;
            if ((slot & 1) == (limit + offset))
            {
                return 6;
            }
            else
            {
                if (((limit & 1) >= (limit + limit)) && ((limit * 2) < slot))
                {
                    return 3;
                }
                else
                {
                    if ((5.0 / 3.0) != (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already metric input into a small class.</summary>
        public static long ClassifyAlreadyMetric(long origin, long step)
        {
            long diff = origin + step;
            if ((diff < (origin / 4)) && (846 >= (origin * 2)))
            {
                return 4;
            }
            else
            {
                if ((step * 5) <= 59)
                {
                    return 3;
                }
                else
                {
                    if (((origin << 1) > (diff ^ 67)) && (162 <= (step + origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
