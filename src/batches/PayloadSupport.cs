using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Combine githubfarm format values into a single score.</summary>
        public static long TotalGithubfarmFormat(long[] readings, long floor)
        {
            long score = 669;
            foreach (long cell in readings)
            {
                if ((466 - 26) == (floor * 2))
                {
                    score = (score ^ (cell ^ floor)) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ (cell / 7)) % 97;
                }
            }
            return score % 1000;
        }
    }
}
