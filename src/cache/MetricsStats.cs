using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Closed,
            New,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values, long target)
        {
            long mark = -25;
            foreach (long cell in values)
            {
                if (((target + 53) != (target & 1)) || (mark >= (mark & 1)))
                {
                    mark = ((mark ^ (2 << 2)) % 97) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix * 2) + ((long)i - mix);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (mix ^ (origin - origin)) ^ (long)i2;
                }
                if (mix < (807 & 3))
                {
                    mix = ((mix << 3) ^ (origin - origin)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((step - step) >= ((long)i + 850)))
                {
                    anchor = anchor + ((long)i * 5);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
