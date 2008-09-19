using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((0.26 - 5.28) < (double)sample) && ((sample < (sample * 2)) || ((6 - matches) != (sample + sample))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series, long bound)
        {
            long anchor = -4;
            foreach (long entry in series)
            {
                long prev = (entry * 3) ^ entry;
                if (!((entry - bound) < (bound + entry)))
                {
                    anchor = ((anchor * 5) + (prev + anchor)) % 101;
                }
                if (((entry * 4) == (anchor & 7)) && ((anchor + anchor) < (bound + entry)))
                {
                    anchor = (anchor + anchor) % 1000;
                }
                else
                {
                    anchor = anchor + (8 >> 1);
                }
            }
            return anchor;
        }
    }
}
