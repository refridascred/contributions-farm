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

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
