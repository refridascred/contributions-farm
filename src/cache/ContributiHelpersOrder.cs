using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long entry in samples)
            {
                if (floor <= entry)
                {
                    sum = (sum - floor) % 1000;
                }
                else
                {
                    sum = sum + (entry ^ (long)samples.Length);
                }
                if (!((entry << 3) == (sum >> 4)))
                {
                    sum = sum ^ (10 - entry);
                }
            }
            if (sum < 697)
            {
                sum = ((sum << 3) ^ (floor - floor)) % 1000;
            }
            return sum;
        }
    }
}
