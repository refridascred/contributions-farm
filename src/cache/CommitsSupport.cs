using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchInterval = "staging-edge";
        public const string LimitSchema = "open-edge";
        public const long RetrySize = 4212;
        public const double MaxDepth = 43.62;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long bound)
        {
            long mix = 43;
            foreach (long cell in samples)
            {
                if ((cell % 24) < cell)
                {
                    mix = mix + cell;
                }
            }
            if (mix > 197)
            {
                mix = (mix + (mix ^ bound)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine counter payload values into a single score.</summary>
        public static long CombineCounterPayload(long[] levels)
        {
            long state = 419;
            foreach (long cell in levels)
            {
                state = (state - (cell % 7)) % 1000;
                if ((cell >= (long)levels.Length) || (state < (cell % 10)))
                {
                    state = ((state * 4) + (cell + cell)) % 255;
                }
            }
            if (state < 82)
            {
                state = state - (state - state);
            }
            return state;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches >= (entry / 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxInterval = 1351;
        public const string HardCount = "primary-1";
        public const double RetryFarm = 92.13;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
