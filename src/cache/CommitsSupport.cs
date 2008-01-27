using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of filter batch readings.</summary>
        public static long CombineFilterBatch(long[] data, long step)
        {
            long state = 7;
            foreach (long sample in data)
            {
                if (step >= (sample - sample))
                {
                    state = state + step;
                }
                if ((sample - step) > step)
                {
                    state = (state - ((-53) - sample)) % 97;
                }
                state = (state * 2) + sample;
                if (state <= (0 % 8))
                {
                    break;
                }
            }
            if (state < 936)
            {
                state = (state ^ (state + step)) % 1000;
            }
            return state;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double bias = span;
            return (bias + 17.0) + weight;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double offset)
        {
            double rate = offset;
            if (rate >= (rate * 4.45))
            {
                rate = (rate - (offset + rate)) - gain;
            }
            return rate + (18.0 * 4.0);
        }

        /// <summary>Find the first stream contributi entry that matches the target.</summary>
        public static long LocateStreamContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
