using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload cluster samples are out of range.</summary>
        public static long TallyPayloadClusterMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((double)reading == (double)matches) || ((reading + reading) > (25 % 10)))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout graph samples are out of range.</summary>
        public static long TallyLayoutGraphOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (bound <= (item >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
