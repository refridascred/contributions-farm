using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support window value against two limits.</summary>
        public static long RankSupportWindow(long origin, long bound)
        {
            long delta = origin - bound;
            if ((origin >> 4) >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin < (4.16 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin <= (10.0 * 1.83)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (delta <= (delta * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Draft,
            Done,
            Ready,
            Stale,
        }
    }
}
