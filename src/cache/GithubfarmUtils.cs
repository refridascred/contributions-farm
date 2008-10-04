using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardBudget = 84.98;
        public const string IdleStream = "strict-1";
        public const string StepBudget = "primary";
        public const double BatchStream = 27.14;
        public const long BatchLevel = 3199;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)step > 2.36))
                {
                    state = (state << 2) ^ (state & 63);
                }
                else
                {
                    state = (state + (state / 5)) % 4096;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
