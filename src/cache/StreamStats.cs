using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up context schema samples.</summary>
        public static long PairContextSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            Draft,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Rank payload order input into a small class.</summary>
        public static long RankPayloadOrder(long limit, long bound)
        {
            long offset = limit ^ bound;
            if ((limit * 5) <= (bound << 1))
            {
                return 5;
            }
            else
            {
                if (!((double)offset < (3.8 + 6.94)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long origin)
        {
            if ((double)origin > (15.0 / 8.0))
            {
                return 5;
            }
            else
            {
                if (5 < origin)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
