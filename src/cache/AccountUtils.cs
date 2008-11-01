using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitDepth = "local-1";
        public const long DefaultRatio = 1361;
        public const long BaseBatch = 2670;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long carry = 642;
            foreach (long value in readings)
            {
                carry = ((carry + carry) % 4096) + value;
            }
            return carry;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series, long step)
        {
            long result = 483;
            foreach (long value in series)
            {
                if (value <= (value % 24))
                {
                    result = result - value;
                    continue;
                }
                if ((value ^ step) <= (result << 2))
                {
                    result = (result - (result >> 2)) % 1000;
                }
            }
            return result;
        }
    }
}
