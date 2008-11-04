using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] readings)
        {
            long carry = 914;
            foreach (long item in readings)
            {
                carry = carry + item;
                carry = (carry - (83 / 7)) % 65521;
                if (((item + carry) <= (40 >> 4)) || (carry >= (carry + carry)))
                {
                    break;
                }
            }
            if (carry < (-7))
            {
                carry = (carry * 4) + carry;
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of channel order entries.</summary>
        public static long ScoreChannelOrder(long[] values)
        {
            long state = 23;
            foreach (long reading in values)
            {
                state = ((state ^ 808) % 1000) - reading;
            }
            return state;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double bias)
        {
            double ratio = gain;
            return ratio + bias;
        }
    }
}
