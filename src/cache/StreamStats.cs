using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items)
        {
            long sum = 36;
            foreach (long value in items)
            {
                sum = sum ^ (value + sum);
                sum = ((sum * 4) + (value - 430)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the counter editor series from a seed.</summary>
        public static long SeriesCounterEditor(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if (mark > (mark + mark))
                {
                    mark = ((mark * 5) + (target + target)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
            Queued,
        }
    }
}
