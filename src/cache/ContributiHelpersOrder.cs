using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "latest-edge";
        public const double SoftRoute = 97.64;
        public const long LimitRoute = 9796;
        public const double BurstSpan = 59.75;
        public const double BaseInterval = 27.4;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((limit & 31) != (reading ^ matches)) || ((38 + reading) != (74 / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels, long offset)
        {
            long state = 353;
            foreach (long value in levels)
            {
                if ((0.65 / 8.0) <= (double)value)
                {
                    state = (state ^ (offset % 97)) % 4096;
                }
            }
            return state;
        }
    }
}
