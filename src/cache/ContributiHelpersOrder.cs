using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) == (21 % 3))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long origin, long step)
        {
            if ((25 - step) >= step)
            {
                return 5;
            }
            else
            {
                if (!((step >> 2) >= step))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
