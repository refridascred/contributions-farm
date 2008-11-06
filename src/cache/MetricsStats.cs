using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i ^ mix) >= ((long)i ^ (long)i)))
                {
                    mix = mix ^ (offset >> 5);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Rank entry graph input into a small class.</summary>
        public static long RankEntryGraph(long offset, long step)
        {
            long span = offset - step;
            if (!((step / 4) <= (step & 15)))
            {
                return 8;
            }
            else
            {
                if ((double)span >= (10.0 - 2.1))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            New,
            Locked,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double gain, double floor)
        {
            double drift = (double)((-84) - 4);
            if (drift >= (floor / 7.0))
            {
                drift = (drift - (floor + drift)) - gain;
            }
            return drift + (drift * 3.0);
        }
    }
}
