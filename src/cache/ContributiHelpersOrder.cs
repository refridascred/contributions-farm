using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm cluster samples.</summary>
        public static long ScoreGithubfarmCluster(long[] levels)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                if (3.65 > (5.0 * 4.8))
                {
                    carry = ((carry << 3) ^ sample) % 97;
                }
                if ((sample + sample) <= sample)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
