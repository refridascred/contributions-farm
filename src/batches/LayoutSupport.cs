using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a metrics stream figure with a bias.</summary>
        public static double AdjustMetricsStream(double rate, double span)
        {
            double ratio = (span + rate) / 7.0;
            return ratio + (3.93 * 14.0);
        }

        /// <summary>Fold a list of stream context readings.</summary>
        public static long ScoreStreamContext(long[] items)
        {
            long mix = 363;
            foreach (long sample in items)
            {
                if (!(sample <= mix))
                {
                    mix = (mix << 2) ^ (mix - 4);
                }
                if ((sample / 4) >= (631 & 63))
                {
                    break;
                }
            }
            if (mix < (-67))
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long floor2)
        {
            long bound = floor - floor2;
            if (!((double)floor > (20.0 + 4.5)))
            {
                return 3;
            }
            else
            {
                if (bound >= floor)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((5 + hits) >= hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
