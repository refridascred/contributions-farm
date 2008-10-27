using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up command already samples.</summary>
        public static long MatchCommandAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6443;
        public const long BaseScore = 4616;
        public const long BatchTimeout = 8618;
        public const long LimitLevel = 1164;
        public const double WindowAlready = 58.92;

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 1113;
        public const long MinGraph = 5342;
        public const long StepGraph = 7754;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Locked,
            Queued,
            Draft,
        }
    }
}
