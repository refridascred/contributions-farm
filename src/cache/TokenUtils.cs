using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings)
        {
            long anchor = -77;
            foreach (long sample in readings)
            {
                if ((13.0 + 0.13) <= (double)anchor)
                {
                    anchor = (anchor ^ ((long)readings.Length + sample)) % 1000;
                    anchor = anchor ^ (sample ^ sample);
                }
                else
                {
                    anchor = (anchor - sample) % 255;
                }
                anchor = anchor ^ sample;
                anchor = ((anchor << 3) ^ sample) % 101;
            }
            if (anchor < (-683))
            {
                anchor = (anchor ^ (anchor * 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Queued,
            New,
            Retry,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
