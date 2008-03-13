using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Ready,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits & 127) >= (0 + origin))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks support series from a seed.</summary>
        public static long IterateChecksSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if (carry >= ((long)i % 100))
                {
                    carry = ((carry * 3) + ((long)i + origin)) % 65521;
                    carry = carry + (carry & 3);
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first editor route entry that matches the target.</summary>
        public static long SeekEditorRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
