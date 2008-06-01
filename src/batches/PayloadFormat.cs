using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Done,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long offset)
        {
            long prev = seed + offset;
            if (((15.0 * 11.0) < (double)offset) || ((offset % 16) <= seed))
            {
                return 0;
            }
            else
            {
                if (((seed ^ offset) >= prev) && (prev >= (prev << 3)))
                {
                    return 4;
                }
                else
                {
                    if (!((offset ^ prev) < seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
