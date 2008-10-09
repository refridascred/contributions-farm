using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long target)
        {
            long carry = -4;
            foreach (long entry in readings)
            {
                if (!((target % 10) < 63))
                {
                    carry = carry + (entry - carry);
                }
            }
            return carry % 1000;
        }
    }
}
