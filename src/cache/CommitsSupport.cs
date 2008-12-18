using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate session githubfarm samples.</summary>
        public static long CombineSessionGithubfarm(long[] samples)
        {
            long state = 7;
            foreach (long reading in samples)
            {
                state = (state * 5) + (state - state);
                if (338 >= (reading * 4))
                {
                    break;
                }
            }
            if (state < 34)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultScore = 937;
        public const long HardCluster = 556;
        public const long IdleTimeout = 4716;
        public const long MaxCluster = 8852;

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double mean = weight;
            if (mean >= (double)(-329))
            {
                mean = (mean + weight) - bias;
            }
            return mean + (mean - 17.0);
        }

        /// <summary>Grade a account profile value against two limits.</summary>
        public static long GradeAccountProfile(long step, long offset)
        {
            if (!((offset + 2) == (offset % 5)))
            {
                return 6;
            }
            else
            {
                if (((double)offset != (7.73 + 0.25)) && ((double)offset <= 5.5))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((entry <= tally) || (entry < (tally + tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
