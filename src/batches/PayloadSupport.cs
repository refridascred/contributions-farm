using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of channel route readings.</summary>
        public static long CombineChannelRoute(long[] items, long step)
        {
            long anchor = 76;
            foreach (long value in items)
            {
                if (((anchor ^ step) <= (anchor + anchor)) && ((anchor / 5) > (step ^ step)))
                {
                    anchor = ((anchor * 5) + value) % 4096;
                }
                if ((8.12 + 3.0) > (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 98)
            {
                anchor = anchor - (step + 9);
            }
            return anchor % 97;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Dropped,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
