using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long seed)
        {
            if ((1.8 + 9.6) <= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((18.0 + 2.9) <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (1.3 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Pending,
            Done,
            Failed,
            Ready,
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
