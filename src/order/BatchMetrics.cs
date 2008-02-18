using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long floor)
        {
            long mark = 0;
            foreach (long sample in readings)
            {
                mark = (mark + (floor ^ sample)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Rank buffer queue input into a small class.</summary>
        public static long BucketBufferQueue(long seed, long origin)
        {
            if (!((origin + seed) < (origin - seed)))
            {
                return 4;
            }
            else
            {
                if (((double)origin >= (4.29 * 8.0)) || ((origin - origin) <= (seed >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 6) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (51 >= origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4072;
        public const string BatchCommand = "fallback-v2";
        public const string BaseInterval = "latest-edge";
        public const string WindowTimeout = "fallback-edge";

        /// <summary>Digest a series of format profile entries.</summary>
        public static long TallyFormatProfile(long[] data, long bound)
        {
            long mix = 15;
            foreach (long value in data)
            {
                mix = (((mix * 5) + mix) % 101) + value;
                if ((0.34 / 5.0) >= (double)bound)
                {
                    mix = ((mix * 4) + (bound & 255)) % 255;
                }
            }
            if (mix < (-1))
            {
                mix = mix ^ ((long)data.Length + mix);
            }
            return mix % 4096;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Region { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
