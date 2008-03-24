using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                long lane = seed;
                if ((lane * 2) >= (score << 2))
                {
                    score = score - seed;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count - datum) != (count - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
