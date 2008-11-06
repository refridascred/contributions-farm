using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 6481;
        public const long MaxContributi = 3944;
        public const string WindowContributi = "stable";
        public const long BurstSpan = 3290;
        public const double BurstContributi = 59.25;

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long seed)
        {
            if (((seed % 64) >= (35 << 1)) && ((double)seed == (9.7 * 9.3)))
            {
                return 6;
            }
            else
            {
                if (((seed - bound) < (bound << 3)) || (seed < (seed * 2)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowWidth = "primary-v2";
        public const long DefaultAccount = 5592;
        public const long SoftAccount = 5405;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((double)sample >= (double)matches) || ((matches >> 2) <= (matches / 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Failed,
            Draft,
            Locked,
        }
    }
}
