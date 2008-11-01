using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
