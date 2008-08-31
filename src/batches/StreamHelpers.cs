using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long TotalFormatSupport(long[] series, long floor)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                if ((floor - mix) > mix)
                {
                    mix = (((mix << 3) ^ 884) % 65521) - reading;
                }
            }
            if (mix > 74)
            {
                mix = mix - (mix ^ 468);
            }
            return mix;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public double Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples, long seed)
        {
            long carry = 922;
            foreach (long value in samples)
            {
                if (0 < value)
                {
                    carry = (((carry * 4) + (value / 8)) % 101) + seed;
                }
            }
            if (carry > 170)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Closed,
            Pending,
            New,
        }
    }
}
