using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string RetryLevel = "alpha";
        public const long MaxContext = 4006;
        public const long RetryContext = 7878;
        public const double WindowContext = 77.51;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(((reading + count) >= count) && (((long)levels.Length - 16) >= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] data)
        {
            long result = 1;
            foreach (long item in data)
            {
                result = ((result * 4) + (item ^ result)) % 97;
                result = (result + 83) % 97;
                result = (result << 2) ^ result;
            }
            return result % 4096;
        }
    }
}
