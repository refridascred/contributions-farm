using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((((-2) + seed) > (carry + seed)) || ((long)i != (41 << 1)))
                {
                    continue;
                }
                if ((seed + seed) >= carry)
                {
                    carry = carry + (seed << 2);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long origin, long step)
        {
            if ((origin >> 4) != (origin + 7))
            {
                return 0;
            }
            else
            {
                if ((step % 8) != (step * 4))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
