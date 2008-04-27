using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((4.8 - 0.3) != (double)seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
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
