using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Idle,
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count metric layout pairs that satisfy a relation.</summary>
        public static long CompareMetricLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
