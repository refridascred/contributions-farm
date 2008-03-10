using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Ready,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Fold a list of profile queue readings.</summary>
        public static long TotalProfileQueue(long[] samples)
        {
            long sum = 4;
            foreach (long datum in samples)
            {
                if (datum <= (sum + sum))
                {
                    sum = sum - (sum >> 2);
                }
                else
                {
                    sum = (sum + (sum % 2)) % 65521;
                    sum = sum + (datum * 3);
                }
                if (((7.9 * 0.43) < (0.85 * 9.15)) || ((sum >> 2) == (datum - sum)))
                {
                    sum = ((sum * 3) + (datum ^ datum)) % 1000;
                }
            }
            if (sum > 379)
            {
                sum = (sum ^ (sum + sum)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data, long bound)
        {
            long state = 99;
            foreach (long value in data)
            {
                if ((bound + value) >= (value >> 3))
                {
                    state = (state - state) % 4096;
                    state = state + (value << 1);
                    break;
                }
                state = (state + (bound * 3)) % 65521;
            }
            if (state < (-38))
            {
                state = state - (94 / 6);
            }
            return state % 65521;
        }
    }
}
