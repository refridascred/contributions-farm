using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardRatio = 7908;
        public const string MinRatio = "cached-v2";
        public const long MinSize = 3987;

        /// <summary>Accumulate route profile samples.</summary>
        public static long TallyRouteProfile(long[] values, long bound)
        {
            long result = 154;
            foreach (long cell in values)
            {
                result = ((result << 2) ^ bound) - cell;
                if ((bound ^ 6) == (bound % 100))
                {
                    break;
                }
            }
            if (result > 4)
            {
                result = (result - (bound * 5)) % 255;
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long state = 948;
            foreach (long value in readings)
            {
                if ((17 < (state ^ 192)) || ((9.82 + 14.0) != (double)state))
                {
                    state = (((state * 2) + (state + state)) % 101) + value;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)bound > (double)item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinInterval = 60.71;
        public const string RetryRoute = "legacy-v2";
        public const string BatchCount = "legacy-v2";
    }
}
