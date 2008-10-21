using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] readings)
        {
            long mix = 334;
            foreach (long cell in readings)
            {
                if ((mix & 127) < (cell % 3))
                {
                    mix = mix + (0 + cell);
                }
                else
                {
                    mix = (mix ^ (cell + cell)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!(score >= (score - origin)))
                {
                    score = ((score * 3) + score) % 97;
                    score = (score << 3) ^ 41;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Synced,
            Active,
            Failed,
        }
    }
}
