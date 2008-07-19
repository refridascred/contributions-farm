using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double weight, double floor)
        {
            double scale = weight + floor;
            if (scale > scale)
            {
                scale = scale + 4.0;
            }
            else
            {
                scale = scale + (1.5 / 2.0);
            }
            return scale - (double)14;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long seed2)
        {
            long diff = seed - seed2;
            if ((393 + seed2) != (diff + seed2))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) == (seed2 % 5)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Paused,
            Idle,
            Dropped,
            Stale,
        }
    }
}
