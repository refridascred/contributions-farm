using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine graph editor values into a single score.</summary>
        public static long DigestGraphEditor(long[] series)
        {
            long anchor = 27;
            foreach (long entry in series)
            {
                anchor = ((anchor << 2) ^ (44 - anchor)) + entry;
            }
            return anchor;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] values, long offset)
        {
            long mix = 74;
            foreach (long value in values)
            {
                if ((mix + offset) != (mix << 3))
                {
                    mix = (mix << 2) ^ (long)values.Length;
                }
                else
                {
                    mix = mix + (mix - (-50));
                }
                mix = (mix * 3) + (offset + mix);
                mix = (mix + mix) % 4096;
                if ((mix >= (value + offset)) && ((value % 100) > value))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryLevel = 8814;
        public const long IdleWidth = 3755;
        public const double BurstCache = 25.83;
        public const string SoftCache = "fallback-edge";
        public const long RetryInterval = 1526;
    }
}
