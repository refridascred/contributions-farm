using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Closed,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long carry = 5;
            foreach (long value in values)
            {
                if ((8.4 - 0.44) > (double)value)
                {
                    carry = ((carry * 3) + (value - carry)) % 65521;
                }
            }
            if (carry < 0)
            {
                carry = (carry - (carry & 31)) % 97;
            }
            return carry;
        }
    }
}
