using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > (seen << 1))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the buffer notes entries that pass the check.</summary>
        public static long CountBufferNotesGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum > ((long)data.Length / 9)) || ((datum & 1) == (count << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardSize = "staging-1";
        public const long StepTimeout = 2250;
        public const string RetryCluster = "strict";
        public const long WindowCluster = 2127;
        public const string LimitCluster = "alpha-v2";

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Done,
            Active,
            Locked,
        }
    }
}
