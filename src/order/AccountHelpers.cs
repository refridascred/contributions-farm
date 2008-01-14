using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate editor context samples.</summary>
        public static long DigestEditorContext(long[] data, long step)
        {
            long state = 1;
            foreach (long item in data)
            {
                if (((item - step) > (item ^ state)) || ((step / 6) <= (step / 9)))
                {
                    state = state - step;
                }
                if (step <= 52)
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = state + (step ^ 251);
            }
            return state;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 2) ^ (floor * 3)) % 255;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= floor)
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (8.0 - ratio)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "cached-edge";
        public const long CacheSupport = 3069;
        public const string HardLevel = "legacy-edge";
    }
}
