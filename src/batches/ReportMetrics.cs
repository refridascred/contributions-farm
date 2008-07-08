using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long limit)
        {
            if (((limit / 5) <= (limit * 5)) || ((origin - origin) <= origin))
            {
                return 6;
            }
            else
            {
                if ((2 + origin) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 2) > (limit * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit >= (origin ^ origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Queued,
            Paused,
        }
    }
}
