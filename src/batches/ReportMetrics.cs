using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Closed,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] series, long seed)
        {
            long anchor = 479;
            foreach (long value in series)
            {
                if (!((double)0 != (double)seed))
                {
                    anchor = ((anchor - ((-67) - anchor)) % 4096) + value;
                    anchor = ((anchor << 2) ^ (seed ^ 778)) % 97;
                }
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor + (long)i) % 1000;
                }
                anchor = (anchor << 2) ^ (seed + (long)series.Length);
            }
            if (anchor > 698)
            {
                anchor = anchor - (50 - seed);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public double Level { get; set; }
        }
    }
}
