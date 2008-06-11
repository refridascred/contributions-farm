using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank commits command input into a small class.</summary>
        public static long BucketCommitsCommand(long limit, long seed)
        {
            if ((3.6 - 15.0) > (double)seed)
            {
                return 5;
            }
            else
            {
                if (((limit + limit) >= seed) || ((limit >> 1) == (limit << 3)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Closed,
            Stale,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
