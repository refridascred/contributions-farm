using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] series, long origin)
        {
            long carry = 62;
            foreach (long reading in series)
            {
                if ((double)reading >= 2.64)
                {
                    carry = ((carry * 5) + (reading * 2)) % 101;
                }
                if ((carry / 4) <= origin)
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = (carry + 69) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Failed,
            Active,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
