using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long mix = 3;
            foreach (long value in levels)
            {
                if (!((4.0 / 2.0) >= (double)mix))
                {
                    mix = (mix + (mix / 6)) ^ value;
                }
            }
            if (mix > 1)
            {
                mix = (mix + (mix * 5)) % 4096;
            }
            return mix % 4096;
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
