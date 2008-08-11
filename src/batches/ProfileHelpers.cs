using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] levels)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                if (!((55 + mix) != (sample / 9)))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = (mix - sample) % 4096;
                }
            }
            if (mix > 10)
            {
                mix = (mix - (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Locate a stats session reading by value.</summary>
        public static long LocateStatsSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double load = gain;
            if (load < offset)
            {
                load = load + (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 5717;
        public const long HardWidth = 5749;
        public const string BaseCount = "legacy-v2";
        public const long DefaultTimeout = 9012;

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
