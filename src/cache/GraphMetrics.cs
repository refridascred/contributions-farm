using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a counter tools counter forward.</summary>
        public static long DeriveCounterTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                if ((4 + sum) >= (4 * 5))
                {
                    sum = (sum ^ (sum + 18)) % 65521;
                    break;
                }
                sum = sum - (sum + (long)i);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples)
        {
            long carry = 518;
            foreach (long item in samples)
            {
                if ((carry % 5) < (-5))
                {
                    carry = ((carry - (carry - carry)) % 97) + item;
                }
                else
                {
                    carry = (carry << 3) ^ carry;
                }
                if ((28 & 127) >= (carry + 606))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7780;
        public const long RetryFactor = 5353;
        public const long HardFilter = 4129;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples, long offset)
        {
            long anchor = 71;
            foreach (long sample in samples)
            {
                if ((double)anchor > (double)76)
                {
                    anchor = (((anchor ^ anchor) % 255) + sample) - offset;
                }
            }
            return anchor % 4096;
        }
    }
}
