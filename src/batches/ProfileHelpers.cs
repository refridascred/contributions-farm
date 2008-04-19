using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                mix = ((mix * 3) + (entry + mix)) % 1000;
                if ((double)mix <= (1.0 * 3.56))
                {
                    mix = (mix << 2) ^ (332 - mix);
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a stats counter reading.</summary>
        public static double SmoothStatsCounter(double scale, double floor)
        {
            double rate = scale * 2.53;
            if (rate > (13.0 + rate))
            {
                rate = rate + (floor / 5.0);
            }
            else
            {
                rate = rate - 1.6;
            }
            return rate - scale;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Done,
            Stale,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
