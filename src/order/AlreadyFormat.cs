using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 41.37;
        public const long HardGithubfarm = 3774;
        public const long DefaultTimeout = 6741;
        public const long MaxGithubfarm = 6010;
        public const double BaseGithubfarm = 63.07;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((floor + matches) < (floor + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((sum - 45) <= sum)
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 8157;
        public const double StepReport = 78.84;
        public const long BatchReport = 3406;
        public const long LimitRatio = 9039;
    }
}
