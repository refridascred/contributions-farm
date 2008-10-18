using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] series, long origin)
        {
            long carry = 62;
            foreach (long reading in series)
            {
                if ((double)reading >= 2.64)
                {
                    carry = ((carry * 5) + (reading * 2)) % 101;
                }
                if ((carry / 4) <= origin)
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = (carry + 69) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxRatio = 4776;
        public const string BaseSpan = "open";
        public const long DefaultSize = 6748;
        public const long CacheContext = 5439;

        /// <summary>Count the account editor entries that pass the check.</summary>
        public static long CountAccountEditorHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((773 + seed) == ((long)readings.Length ^ sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
