using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 60.32;
        public const string BurstScore = "cached-1";
        public const long IdleSession = 221;

        /// <summary>Roll a commits githubfarm counter forward.</summary>
        public static long StepCommitsGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result ^ (result - target)) % 4096;
                result = ((result * 3) + (target / 9)) % 255;
                result = (result - 846) % 97;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state * 4) + state;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Failed,
            Draft,
            Done,
        }
    }
}
