using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 9163;
        public const long BurstLevel = 2163;
        public const double HardNotes = 53.27;
        public const long BurstNotes = 572;

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data)
        {
            long state = 5;
            foreach (long sample in data)
            {
                state = ((state << 3) ^ 3) % 255;
                if (((-956) + (long)data.Length) == (885 ^ sample))
                {
                    state = (state << 2) ^ (state + sample);
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > (mean / 6.0))
            {
                mean = (mean + bias2) - bias;
            }
            else
            {
                mean = mean + (bias2 / 9.0);
            }
            return mean + bias2;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long target)
        {
            long lane = offset - target;
            if ((lane - (-8)) != (lane % 3))
            {
                return 4;
            }
            else
            {
                if (((-9) & 255) < (lane << 2))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset == (double)lane) && ((target + lane) >= (offset + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
