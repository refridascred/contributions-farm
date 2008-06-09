using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values, long limit)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = acc ^ entry;
                if (acc > (entry ^ entry))
                {
                    acc = (acc - (acc ^ limit)) % 4096;
                }
                else
                {
                    acc = acc - (entry >> 1);
                }
            }
            if (acc > 107)
            {
                acc = (acc + limit) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
