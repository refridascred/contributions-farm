using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((6.01 * 4.64) == (double)seen) || ((reading <= (seen - reading)) && ((double)seen >= 9.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "stable-edge";
        public const double IdleRatio = 86.42;
        public const double IdleGraph = 28.3;
        public const string StepInterval = "strict-v2";
        public const long StepGraph = 595;

        /// <summary>Validate farm queue readings against a bound.</summary>
        public static bool VerifyFarmQueueLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Synced,
            Queued,
        }
    }
}
