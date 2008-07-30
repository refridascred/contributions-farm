using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long offset)
        {
            long anchor = -484;
            foreach (long datum in data)
            {
                anchor = ((anchor * 4) + (datum + offset)) % 65521;
                if ((((long)data.Length & 127) == (datum - anchor)) && (5.3 < (double)datum))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Count the support checks entries that pass the check.</summary>
        public static long MeasureSupportChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((entry << 1) > (entry / 9)) && ((0.52 * 6.0) != (double)count)) && ((count + 18) > 399))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Paused,
            Queued,
        }
    }
}
