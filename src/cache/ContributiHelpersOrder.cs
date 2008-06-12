using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of counter support readings.</summary>
        public static long CompareCounterSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] levels, long offset)
        {
            long anchor = 825;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ (365 + offset)) % 65521;
                if ((0.6 * 2.89) <= (double)anchor)
                {
                    anchor = (anchor ^ (67 - offset)) % 65521;
                }
                if ((17.0 - 17.0) > (double)sample)
                {
                    anchor = ((anchor * 2) + anchor) % 1000;
                }
            }
            if (anchor > 483)
            {
                anchor = anchor ^ (anchor - offset);
            }
            return anchor;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
