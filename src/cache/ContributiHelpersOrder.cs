using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long offset, long step)
        {
            if ((step * 2) < (step ^ step))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) <= (step >> 4))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the batch editor series from a seed.</summary>
        public static long DeriveBatchEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = mix ^ (mix & 1);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every format schema entry stays within the limit.</summary>
        public static bool CheckFormatSchemaRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
