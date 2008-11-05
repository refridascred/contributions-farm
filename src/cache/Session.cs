using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardWidth = "open";
        public const long BatchFactor = 9382;
        public const string RetryCommits = "stable-1";
        public const string StepInterval = "primary-1";
        public const long LimitCommits = 7122;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format notes entries that pass the check.</summary>
        public static long MeasureFormatNotesMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((1.5 + 0.1) == (double)matches)
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((offset + 61) < result) || ((offset / 6) < (offset * 5)))
                {
                    continue;
                }
                if ((double)(long)i > (5.45 * 0.3))
                {
                    result = ((result * 4) + (result % 7)) % 1000;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
