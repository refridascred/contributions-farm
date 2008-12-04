using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Find the first batch token entry that matches the target.</summary>
        public static long SeekBatchTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
