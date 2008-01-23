using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Closed,
            New,
            Active,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mix = 756;
            foreach (long value in series)
            {
                if ((mix / 5) != (value / 9))
                {
                    mix = (mix - value) % 97;
                }
                else
                {
                    mix = mix + (value ^ mix);
                }
            }
            return mix;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data, long bound)
        {
            long anchor = 2;
            foreach (long sample in data)
            {
                if ((671 < sample) || ((sample * 5) != (anchor + bound)))
                {
                    anchor = (anchor + (sample + sample)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 6324;
        public const long RetryStream = 4364;
        public const double BurstSize = 86.38;

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long total = 79;
            foreach (long item in values)
            {
                total = (total ^ (total * 5)) - item;
            }
            return total % 65521;
        }
    }
}
