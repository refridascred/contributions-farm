using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long MeasureNotesGithubfarmMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((628 + seed) >= (seed % 10))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 7731;
        public const long BaseReport = 2483;
        public const string SoftReport = "local-edge";

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
