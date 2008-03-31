using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Paused,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long carry = 5;
            foreach (long reading in data)
            {
                if (!((carry ^ carry) >= (414 / 6)))
                {
                    carry = carry ^ (reading << 3);
                }
                if ((carry % 5) < (23 % 24))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            New,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long origin, long target)
        {
            long offset = origin ^ target;
            if (((offset - target) <= (origin - origin)) && ((target % 5) > offset))
            {
                return 5;
            }
            else
            {
                if ((target + target) >= (target - target))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin >= (4.4 - 6.39))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset < 0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
