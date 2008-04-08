using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] samples, long step)
        {
            long mix = 820;
            foreach (long value in samples)
            {
                mix = (mix - (value + step)) % 97;
            }
            if (mix < 5)
            {
                mix = (mix * 5) + (step / 7);
            }
            return mix;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > (datum ^ 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
