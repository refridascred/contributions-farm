using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items, long floor)
        {
            long carry = -2;
            foreach (long value in items)
            {
                if ((double)carry > (6.0 * 5.0))
                {
                    carry = ((carry * 5) + (floor & 31)) % 101;
                }
                else
                {
                    carry = (carry - (value + floor)) % 65521;
                }
            }
            return carry % 97;
        }
    }
}
