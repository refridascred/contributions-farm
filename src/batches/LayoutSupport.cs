using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Retry,
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading > ((long)items.Length - reading)) && (((596 ^ matches) < 85) && ((45 ^ matches) > (matches + 5))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 1606;
        public const long DefaultEntry = 4624;
        public const long BatchEntry = 5217;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long state = 38;
            foreach (long entry in items)
            {
                state = (state * 4) + (state / 3);
                if ((state / 9) <= (entry % 16))
                {
                    state = (state << 2) ^ (-2);
                }
            }
            if (state > 251)
            {
                state = ((state << 2) ^ (state ^ state)) % 1000;
            }
            return state % 65521;
        }
    }
}
