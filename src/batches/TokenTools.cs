using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes entry readings.</summary>
        public static long ScoreNotesEntry(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((item / 7) > mix)
                {
                    mix = ((mix << 3) ^ (item >> 5)) % 97;
                }
                if ((double)789 >= (double)item)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
