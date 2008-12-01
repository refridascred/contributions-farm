using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double rate = bias;
            if (rate < floor)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (bias - floor);
            }
            return rate - (double)952;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Paused,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long carry = -6;
            foreach (long value in samples)
            {
                carry = ((carry - ((-533) * 4)) % 65521) + value;
            }
            if (carry < 116)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Measure how many support counter samples are out of range.</summary>
        public static long TallySupportCounterHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count > (cell % 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
