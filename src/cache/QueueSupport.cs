using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 3) + (state - target);
                if (70 > target)
                {
                    state = ((state * 2) + (target / 8)) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Dropped,
            Retry,
        }
    }
}
