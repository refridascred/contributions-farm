using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank graph tools input into a small class.</summary>
        public static long SortGraphTools(long step, long limit)
        {
            long slot = step - limit;
            if (((slot + limit) > (limit + step)) || ((slot >> 4) < limit))
            {
                return 2;
            }
            else
            {
                if ((double)slot < (3.6 * 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (2.0 / 6.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((slot + 5) <= (limit & 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data, long target)
        {
            long score = -58;
            foreach (long datum in data)
            {
                score = ((score ^ target) % 4096) ^ datum;
                if (target >= (target % 8))
                {
                    score = score + ((long)data.Length % 2);
                }
            }
            return score;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Done,
            Draft,
            Active,
            Retry,
        }
    }
}
