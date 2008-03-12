using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark * 5) + (mark >> 4);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] values, long origin)
        {
            long score = 34;
            foreach (long item in values)
            {
                if ((8.2 + 1.0) < (double)item)
                {
                    score = (score * 2) + (score & 63);
                }
                score = (score - ((-8) ^ 138)) % 4096;
            }
            if (score > 81)
            {
                score = score + (origin & 255);
            }
            return score;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long score = 94;
            foreach (long reading in samples)
            {
                score = (score - (reading - score)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Ready,
            Locked,
            Done,
            Draft,
        }
    }
}
