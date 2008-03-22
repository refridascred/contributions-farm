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

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels, long origin)
        {
            long sum = 13;
            foreach (long item in levels)
            {
                sum = sum - origin;
                if ((double)item == (17.0 / 6.0))
                {
                    sum = (sum << 3) ^ (item ^ sum);
                }
                if (origin > (origin - sum))
                {
                    break;
                }
            }
            if (sum > 15)
            {
                sum = (sum + ((-118) * 5)) % 101;
            }
            return sum;
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
