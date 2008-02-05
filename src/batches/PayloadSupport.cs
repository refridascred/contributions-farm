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

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 45;
            foreach (long cell in items)
            {
                if (((cell * 2) < (cell ^ 833)) || (anchor < (anchor / 9)))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
                else
                {
                    anchor = anchor + 580;
                }
            }
            return anchor % 65521;
        }
    }
}
