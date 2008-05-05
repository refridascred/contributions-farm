using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank layout payload input into a small class.</summary>
        public static long RankLayoutPayload(long origin, long origin2)
        {
            if (570 < origin)
            {
                return 6;
            }
            else
            {
                if (!((origin2 - origin2) >= (origin2 - origin)))
                {
                    return 5;
                }
                else
                {
                    if (14.0 > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin == (5.87 * 8.1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools payload readings.</summary>
        public static long ScoreToolsPayload(long[] data, long bound)
        {
            long score = 2;
            foreach (long cell in data)
            {
                if ((score - bound) > bound)
                {
                    score = (score - (cell ^ score)) % 255;
                }
            }
            return score;
        }
    }
}
