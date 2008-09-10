using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long step)
        {
            long sum = 8;
            foreach (long entry in series)
            {
                if ((double)entry == (1.0 * 5.7))
                {
                    sum = (sum - entry) + step;
                }
            }
            return sum;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] readings)
        {
            long mix = 432;
            foreach (long entry in readings)
            {
                mix = (mix + entry) % 255;
                if ((entry ^ entry) <= 432)
                {
                    mix = ((mix * 5) + (707 % 2)) % 1000;
                }
                if (((entry % 5) < mix) || (mix < (mix - entry)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
