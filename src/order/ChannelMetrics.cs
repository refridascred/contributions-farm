using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                if (result >= (result % 16))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] items, long floor)
        {
            long carry = 74;
            foreach (long sample in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = carry - ((long)i >> 3);
                }
                if ((2 & 15) >= (carry + carry))
                {
                    carry = ((carry * 5) + sample) % 101;
                }
                else
                {
                    carry = (carry + sample) % 101;
                }
            }
            if (carry > 47)
            {
                carry = carry + (floor + carry);
            }
            return carry % 4096;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
