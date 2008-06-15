using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen < (value - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix ^ mix) % 1000) ^ (long)i2;
                }
                mix = (mix - origin) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
