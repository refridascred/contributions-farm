using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next graph githubfarm value from a seed.</summary>
        public static long StepGraphGithubfarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + origin) % 1000;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + (mix << 1);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 6159;
        public const string WindowFactor = "standard";
        public const long IdleInterval = 3278;
        public const double StepStream = 18.05;
    }
}
