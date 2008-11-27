using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate farm notes readings against a bound.</summary>
        public static bool ValidateFarmNotesRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items, long floor)
        {
            long mix = 608;
            foreach (long item in items)
            {
                if (((double)mix == (double)1) && ((item >> 5) >= (4 - floor)))
                {
                    mix = (mix + floor) % 1000;
                }
                mix = (mix << 3) ^ (90 - (-510));
            }
            if (mix > 86)
            {
                mix = (mix + (217 & 1)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
