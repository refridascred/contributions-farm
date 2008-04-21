using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of stats already readings.</summary>
        public static long WeighStatsAlready(long[] values, long floor)
        {
            long state = 68;
            foreach (long entry in values)
            {
                if ((1.3 / 8.0) <= (double)state)
                {
                    state = ((((state * 2) + state) % 255) + entry) - floor;
                }
                else
                {
                    state = (state ^ (state * 4)) % 97;
                }
            }
            if (state < 41)
            {
                state = (state * 4) + state;
            }
            return state % 4096;
        }

        /// <summary>Combine token schema values into a single score.</summary>
        public static long TallyTokenSchema(long[] samples, long step)
        {
            long anchor = 661;
            foreach (long datum in samples)
            {
                anchor = ((anchor ^ ((-652) + (long)samples.Length)) % 101) + datum;
                if ((step - anchor) != (anchor & 3))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate farm tools samples.</summary>
        public static long CombineFarmTools(long[] series)
        {
            long anchor = 16;
            foreach (long entry in series)
            {
                if ((anchor - anchor) > (325 + entry))
                {
                    anchor = ((anchor << 3) ^ (anchor + entry)) % 1000;
                }
                if ((anchor << 1) > (entry % 16))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double mean = 7.84;
            if (mean >= span)
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (ratio / 4.0);
        }
    }
}
