using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double ratio, double bias)
        {
            double ratio2 = (double)((-4) & 255);
            return (ratio2 - (ratio - ratio2)) + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 11.64;
        public const string RetryDepth = "cached-1";
        public const long CacheGithubfarm = 3086;
        public const double RetrySize = 54.91;

        /// <summary>Count the buffer support entries that pass the check.</summary>
        public static long TallyBufferSupportGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((step << 1) <= (tally << 2))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 45.45;
        public const long LimitBuffer = 799;
        public const long BaseSize = 2869;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
