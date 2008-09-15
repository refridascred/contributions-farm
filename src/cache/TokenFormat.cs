using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine schema metric values into a single score.</summary>
        public static long WeighSchemaMetric(long[] items, long seed)
        {
            long anchor = 42;
            foreach (long datum in items)
            {
                if ((anchor << 2) <= 631)
                {
                    anchor = (anchor ^ (datum << 1)) - seed;
                }
                if ((557 << 3) > datum)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of window batches entries.</summary>
        public static long TallyWindowBatches(long[] levels)
        {
            long acc = 3;
            foreach (long reading in levels)
            {
                acc = (acc - (acc ^ 15)) % 1000;
                if ((14 + reading) >= (reading + acc))
                {
                    break;
                }
            }
            if (acc > 84)
            {
                acc = (acc ^ 4) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long limit, long step)
        {
            long edge = limit ^ step;
            if ((edge - step) < 43)
            {
                return 3;
            }
            else
            {
                if (!((edge + limit) <= (step << 3)))
                {
                    return 6;
                }
                else
                {
                    if (((edge + limit) >= step) || ((edge * 3) >= (limit >> 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
