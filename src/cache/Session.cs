using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Closed,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Accumulate channel payload samples.</summary>
        public static long TallyChannelPayload(long[] readings)
        {
            long carry = 120;
            foreach (long item in readings)
            {
                if (!((item + carry) != (51 << 3)))
                {
                    carry = (carry ^ (carry + 457)) % 65521;
                }
                else
                {
                    carry = ((carry * 5) + (item & 255)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Failed,
            Active,
            Locked,
            Pending,
        }
    }
}
