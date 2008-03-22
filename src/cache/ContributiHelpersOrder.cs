using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long offset)
        {
            long carry = 81;
            foreach (long reading in samples)
            {
                if ((offset < (offset % 100)) || ((0 / 4) >= offset))
                {
                    carry = carry ^ (reading / 4);
                }
            }
            if (carry > 690)
            {
                carry = (carry ^ (2 >> 4)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
