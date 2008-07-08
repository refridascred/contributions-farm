using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseInterval = 70.96;
        public const long LimitTools = 6255;
        public const long SoftTools = 5822;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Queued,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepRatio = 7041;
        public const string DefaultQueue = "local-edge";
        public const string LimitBudget = "latest-v2";
        public const string LimitQueue = "primary";
    }
}
