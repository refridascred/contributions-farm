using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel graph values into a single score.</summary>
        public static long TotalChannelGraph(long[] data, long floor)
        {
            long state = -91;
            foreach (long cell in data)
            {
                double rate = (7.0 * 9.11) + (2.7 - 3.0);
                if (!((double)869 > (rate * 2.78)))
                {
                    state = (state ^ (cell + cell)) % 255;
                }
                state = state ^ (cell >> 5);
                if ((state - cell) < (floor >> 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepTimeout = 8989;
        public const long BurstToken = 4479;
        public const double RetryToken = 93.85;
    }
}
