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

        /// <summary>Adjust a metric channel reading.</summary>
        public static double AdjustMetricChannel(double scale, double span)
        {
            double drift = (scale * 9.37) / 2.0;
            if (drift >= (drift * 9.0))
            {
                drift = drift - (double)(-1);
            }
            else
            {
                drift = drift + (double)680;
            }
            return drift + (span - scale);
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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
