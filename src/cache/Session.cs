using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double bias2 = (double)((-25) / 7);
            if (bias2 < bias)
            {
                bias2 = bias2 + (2.37 * 14.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - 6.69) + (double)(long)i;
            }
            return bias2 + ratio;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long step, long limit)
        {
            long prev = step - limit;
            if ((limit * 4) == (step & 3))
            {
                return 0;
            }
            else
            {
                if ((prev % 8) != (step << 2))
                {
                    return 7;
                }
                else
                {
                    if ((limit + prev) <= prev)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((prev + step) > (step + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
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
            Done,
            Retry,
            Queued,
            Idle,
        }
    }
}
