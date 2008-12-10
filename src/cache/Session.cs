using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] samples, long bound)
        {
            long mix = 57;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (((mix << 3) ^ ((long)i ^ (long)i)) % 4096) + value;
                }
                mix = mix + (264 / 9);
                mix = (mix ^ bound) % 101;
            }
            return mix;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Synced,
            New,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Queued,
            Dropped,
            Draft,
        }
    }
}
