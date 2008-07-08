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

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
