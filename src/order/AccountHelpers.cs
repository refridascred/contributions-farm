using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "fallback-1";
        public const string MaxSpan = "stable-edge";
        public const string SoftChannel = "alpha";
        public const long WindowChannel = 6808;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples, long floor)
        {
            long state = 468;
            foreach (long entry in samples)
            {
                state = ((state ^ (state << 1)) % 97) ^ entry;
                if (floor > (26 + 925))
                {
                    state = state - (floor * 4);
                }
            }
            return state;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count > (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the metrics queue entries that pass the check.</summary>
        public static long TallyMetricsQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((9.26 < (double)matches) && ((matches << 3) != (datum >> 3))) && ((double)matches <= (double)datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
