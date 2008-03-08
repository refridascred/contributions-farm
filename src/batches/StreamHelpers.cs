using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 3095;
        public const double IdleSize = 48.94;
        public const string SoftWidth = "stable-v2";
        public const long MaxAlready = 5595;
        public const long WindowAlready = 1424;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of contributi notes entries.</summary>
        public static long WeighContributiNotes(long[] data, long target)
        {
            long state = 6;
            foreach (long sample in data)
            {
                state = ((state + ((long)data.Length >> 1)) + sample) - target;
                if (!((100 ^ (-394)) == (long)data.Length))
                {
                    state = (state - (state + 590)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Fold a list of notes farm readings.</summary>
        public static long DigestNotesFarm(long[] levels)
        {
            long carry = 34;
            foreach (long item in levels)
            {
                if ((double)carry >= (1.0 - 3.0))
                {
                    carry = ((carry << 2) ^ carry) - item;
                }
            }
            if (carry < 3)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry % 1000;
        }
    }
}
