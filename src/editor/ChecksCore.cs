using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((long)series.Length >= matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] readings, long origin)
        {
            long sum = 65;
            foreach (long value in readings)
            {
                if (!((9.67 + 0.8) < (double)sum))
                {
                    sum = ((sum << 2) ^ (origin / 3)) ^ value;
                }
                sum = ((sum * 4) + (origin << 1)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseLevel = 5318;
        public const double IdleSpan = 58.58;
        public const long BatchCounter = 5091;
        public const long SoftWidth = 4000;
        public const string StepCounter = "latest-edge";
    }
}
