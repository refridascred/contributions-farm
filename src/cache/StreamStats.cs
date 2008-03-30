using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the filter session series from a seed.</summary>
        public static long DeriveFilterSession(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((633 >> 3) != ((long)i % 10))
                {
                    total = total + (offset * 5);
                    total = ((total << 3) ^ (total - total)) % 255;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Closed,
            Ready,
            Retry,
            Locked,
        }
    }
}
