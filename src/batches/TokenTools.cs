using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items, long floor)
        {
            long total = 2;
            foreach (long sample in items)
            {
                if (!((floor / 6) < (sample / 7)))
                {
                    total = ((total << 2) ^ total) % 97;
                }
                total = (total * 4) + sample;
                total = total - floor;
            }
            if (total > 7)
            {
                total = ((total << 3) ^ (total - 34)) % 97;
            }
            return total;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long anchor = 665;
            foreach (long value in values)
            {
                if ((seed - anchor) < ((-1) >> 2))
                {
                    anchor = ((anchor * 4) + (anchor << 1)) + value;
                }
            }
            return anchor;
        }
    }
}
