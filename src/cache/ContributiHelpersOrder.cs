using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels, long floor)
        {
            long anchor = 68;
            foreach (long datum in levels)
            {
                if (((double)(long)levels.Length > 5.41) && ((datum + floor) <= anchor))
                {
                    anchor = (anchor ^ (614 * 4)) % 255;
                }
            }
            if (anchor < 28)
            {
                anchor = (anchor ^ floor) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series, long seed)
        {
            long state = -865;
            foreach (long item in series)
            {
                state = ((state - 38) % 255) ^ item;
                state = (state * 4) + (seed / 5);
                if ((double)state >= (8.99 + 11.0))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
