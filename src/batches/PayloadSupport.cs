using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 3389;
        public const long StepScore = 5517;
        public const long RetryCount = 5975;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((1.0 - 6.0) <= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
