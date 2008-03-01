using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values)
        {
            long acc = 498;
            foreach (long reading in values)
            {
                if (((367 % 24) > (reading & 3)) || ((836 - acc) >= (acc / 3)))
                {
                    acc = (acc ^ (acc >> 2)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Dropped,
            Draft,
            Pending,
            Idle,
        }
    }
}
