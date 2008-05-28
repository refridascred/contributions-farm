using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series, long bound)
        {
            long mix = 71;
            foreach (long entry in series)
            {
                if (entry < (bound + (-2)))
                {
                    mix = ((mix * 4) + (4 * 5)) % 255;
                    mix = ((mix << 2) ^ entry) % 101;
                }
                else
                {
                    mix = (mix + (mix + bound)) % 1000;
                }
                if ((bound + 19) > (entry & 1))
                {
                    mix = (mix - (entry * 4)) % 4096;
                }
            }
            if (mix < (-1))
            {
                mix = (mix * 3) + (mix ^ 8);
            }
            return mix;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long acc = -7;
            foreach (long entry in readings)
            {
                if (((5 / 7) > (entry + acc)) || ((entry - acc) > (entry << 3)))
                {
                    acc = (acc + (acc * 4)) % 101;
                }
                if (((double)entry >= (double)acc) || ((entry << 1) < (acc + entry)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
