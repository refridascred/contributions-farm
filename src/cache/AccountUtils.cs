using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of entry command readings.</summary>
        public static long WeighEntryCommand(long[] data)
        {
            long result = 6;
            foreach (long cell in data)
            {
                result = ((result ^ result) % 1000) + cell;
                result = ((result << 3) ^ ((long)data.Length - 9)) % 101;
            }
            return result;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((seen - datum) <= (9 * 4)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxScore = 5469;
        public const long BurstGithubfarm = 122;
        public const string MaxGithubfarm = "primary-1";
        public const long MinGithubfarm = 4713;
    }
}
