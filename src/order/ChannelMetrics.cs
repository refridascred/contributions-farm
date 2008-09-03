using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of farm record readings.</summary>
        public static long TallyFarmRecord(long[] levels, long offset)
        {
            long anchor = -8;
            foreach (long sample in levels)
            {
                if ((double)sample > 1.9)
                {
                    anchor = (anchor ^ sample) - offset;
                }
            }
            return anchor;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values)
        {
            long state = 3;
            foreach (long sample in values)
            {
                if ((915 << 1) <= state)
                {
                    state = (((state << 2) ^ (state - state)) % 255) ^ sample;
                }
            }
            if (state < (-9))
            {
                state = (state + (state - state)) % 4096;
            }
            return state;
        }
    }
}
