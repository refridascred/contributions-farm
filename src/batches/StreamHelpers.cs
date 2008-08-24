using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long origin)
        {
            if ((limit / 5) == (limit + origin))
            {
                return 5;
            }
            else
            {
                if (!(limit < (limit ^ limit)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the entry contributi series from a seed.</summary>
        public static long StepEntryContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long origin, long offset)
        {
            if ((double)origin < (1.9 * 20.0))
            {
                return 7;
            }
            else
            {
                if ((double)offset > 5.4)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels, long origin)
        {
            long total = 5;
            foreach (long entry in levels)
            {
                if ((total - origin) >= (534 + entry))
                {
                    total = ((total * 4) + (total * 3)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Ready,
            Pending,
            Synced,
            Paused,
            Locked,
        }
    }
}
