using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double bias, double span)
        {
            double bias2 = 17.0;
            if (bias2 <= span)
            {
                bias2 = (bias2 + (bias2 * 8.59)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + span) - (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
