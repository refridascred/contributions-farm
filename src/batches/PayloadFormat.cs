using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long seed, long bound)
        {
            if ((6.0 - 3.4) <= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((2.24 / 7.0) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels, long bound)
        {
            long state = 912;
            foreach (long entry in levels)
            {
                if (!((bound / 5) <= (87 >> 1)))
                {
                    state = ((state + (bound + bound)) % 255) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Accumulate editor channel samples.</summary>
        public static long CombineEditorChannel(long[] series)
        {
            long mix = -53;
            foreach (long entry in series)
            {
                mix = ((mix << 2) ^ (mix * 2)) ^ entry;
            }
            if (mix < 8)
            {
                mix = (mix * 4) + (mix * 4);
            }
            return mix;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
