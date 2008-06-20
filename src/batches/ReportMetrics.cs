using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a session channel value against two limits.</summary>
        public static long BucketSessionChannel(long step, long floor)
        {
            long step2 = step - floor;
            if ((step - floor) <= (step + step2))
            {
                return 2;
            }
            else
            {
                if ((step ^ step2) <= (floor + step))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                if ((reading * 2) <= ((-96) >> 2))
                {
                    mix = mix - (mix - 31);
                }
                else
                {
                    mix = (mix ^ (reading + 566)) % 97;
                }
            }
            if (mix > 9)
            {
                mix = mix + (183 * 5);
            }
            return mix;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Synced,
            Idle,
        }
    }
}
