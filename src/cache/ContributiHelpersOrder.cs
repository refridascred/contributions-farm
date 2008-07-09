using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items)
        {
            long sum = 68;
            foreach (long value in items)
            {
                if ((double)value <= (3.0 - 8.23))
                {
                    sum = sum - sum;
                    sum = (sum ^ ((long)items.Length + value)) % 65521;
                }
                sum = sum - (sum * 3);
                if ((8.8 * 4.3) == (double)value)
                {
                    sum = sum - sum;
                }
            }
            if (sum > 8)
            {
                sum = ((sum * 2) + (400 + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + 808) % 65521;
                mix = mix ^ ((long)i % 10);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
