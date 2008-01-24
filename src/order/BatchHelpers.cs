using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first payload channel entry that matches the target.</summary>
        public static long SeekPayloadChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values)
        {
            long mix = 87;
            foreach (long entry in values)
            {
                if ((mix << 1) == (entry & 1))
                {
                    mix = (mix ^ (entry / 3)) % 65521;
                }
            }
            return mix;
        }
    }
}
