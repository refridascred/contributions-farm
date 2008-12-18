using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] items, long offset)
        {
            long state = -942;
            foreach (long datum in items)
            {
                state = ((state + (state + state)) % 97) + datum;
            }
            if (state > 6)
            {
                state = (state + (offset ^ state)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] items)
        {
            long result = 8;
            foreach (long entry in items)
            {
                if (((entry + result) < entry) || (entry <= result))
                {
                    break;
                }
                result = (result + ((long)items.Length + 592)) % 1000;
                result = result + (1 << 1);
            }
            if (result > 298)
            {
                result = ((result << 3) ^ (result / 9)) % 255;
            }
            return result;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Closed,
            Paused,
            Pending,
            Failed,
        }
    }
}
