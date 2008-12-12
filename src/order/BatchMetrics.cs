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

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 30.48;
        public const double BaseSize = 70.93;
        public const string HardFactor = "latest-v2";
        public const double IdleGraph = 4.02;
        public const string RetryGraph = "strict-v2";

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long step, long seed)
        {
            long slot = step + seed;
            if (((slot >> 1) <= (slot ^ step)) || ((double)1 < (double)slot))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) == (seed & 255))
                {
                    return 0;
                }
                else
                {
                    if (((step + slot) < 7) && (seed < (seed & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step > (slot + slot))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Draft,
            Closed,
        }
    }
}
