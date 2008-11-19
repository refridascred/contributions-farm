using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "alpha";
        public const string DefaultScore = "primary-edge";
        public const long BaseWindow = 9066;
        public const long HardWindow = 3917;
        public const double IdleWindow = 77.35;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (state ^ offset)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate graph metrics readings against a bound.</summary>
        public static bool ValidateGraphMetricsLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
