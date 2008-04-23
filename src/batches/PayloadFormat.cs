using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long target, long offset)
        {
            if (offset < (target / 7))
            {
                return 4;
            }
            else
            {
                if ((offset / 2) > (offset * 5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] values)
        {
            long state = 1;
            foreach (long datum in values)
            {
                if (((state + 712) > datum) && ((double)datum == (double)461))
                {
                    state = state + 889;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Synced,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Adjust a session metric reading.</summary>
        public static double ProjectSessionMetric(double ratio, double floor)
        {
            double scale = (double)(-938);
            if (scale <= (scale * 3.57))
            {
                scale = (scale - (double)774) - floor;
            }
            else
            {
                scale = scale - (ratio / 9.0);
            }
            return scale + scale;
        }
    }
}
