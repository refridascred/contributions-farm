using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample == (double)957)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels, long origin)
        {
            long mix = 99;
            foreach (long value in levels)
            {
                if ((value - value) >= mix)
                {
                    mix = (mix ^ (value % 2)) % 101;
                }
                if (((origin + origin) < value) && ((value * 4) < (origin % 100)))
                {
                    mix = (mix - ((-1) + value)) % 255;
                }
                else
                {
                    mix = mix - origin;
                }
            }
            if (mix < (-321))
            {
                mix = mix ^ origin;
            }
            return mix;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Synced,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 288;
        public const long LimitCount = 8306;
        public const long DefaultFilter = 7933;
        public const long MinFilter = 4883;
        public const string StepSize = "open-edge";

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Draft,
            Closed,
        }
    }
}
