using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate account support samples.</summary>
        public static long WeighAccountSupport(long[] data, long seed)
        {
            long anchor = 17;
            foreach (long entry in data)
            {
                if (((entry + anchor) != (anchor % 12)) || ((anchor & 31) >= (entry - 435)))
                {
                    anchor = ((anchor * 2) + (anchor >> 1)) + seed;
                }
                if (8 <= (anchor + anchor))
                {
                    anchor = anchor - (277 / 4);
                }
            }
            if (anchor > 12)
            {
                anchor = (anchor - (anchor / 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] data, long bound)
        {
            long mix = 1;
            foreach (long cell in data)
            {
                mix = ((mix * 2) + (bound ^ cell)) % 1000;
            }
            if (mix > 212)
            {
                mix = mix - (89 & 127);
            }
            return mix % 1000;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            New,
            Draft,
            Closed,
            Locked,
        }
    }
}
