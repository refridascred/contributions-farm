using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i >> 3) < acc)
                {
                    break;
                }
                else
                {
                    acc = acc ^ (long)i;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc + (limit + acc)) % 255) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every editor order entry stays within the limit.</summary>
        public static bool ValidateEditorOrderBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
