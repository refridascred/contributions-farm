using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((2.7 + 0.3) < (double)floor) && ((reading ^ count) >= (reading + 701)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total - offset)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Mode { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            New,
            Stale,
            Failed,
            Ready,
        }
    }
}
