using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels)
        {
            long mix = 1;
            foreach (long datum in levels)
            {
                mix = ((mix * 3) + (datum + mix)) % 97;
                if (((357 % 10) <= mix) && (7.97 < (double)mix))
                {
                    mix = mix ^ (mix - datum);
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long origin, long limit)
        {
            long edge = origin - limit;
            if (((edge - 8) > (origin + origin)) && ((edge * 3) > origin))
            {
                return 4;
            }
            else
            {
                if (!((edge - edge) < (4 & 1)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
