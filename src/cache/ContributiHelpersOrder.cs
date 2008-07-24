using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a stream schema sample.</summary>
        public static long SeekStreamSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels, long floor)
        {
            long acc = 785;
            foreach (long datum in levels)
            {
                if ((724 - acc) >= (acc - acc))
                {
                    acc = ((acc * 3) + (acc * 5)) + datum;
                }
            }
            if (acc < (-46))
            {
                acc = (acc * 2) + floor;
            }
            return acc % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
