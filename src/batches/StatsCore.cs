using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long mix = 7;
            foreach (long value in readings)
            {
                if ((double)value <= (1.0 / 5.0))
                {
                    mix = (mix + (value << 3)) % 101;
                }
                else
                {
                    mix = mix - mix;
                    mix = (mix - (443 & 31)) % 4096;
                }
                if (8 <= value)
                {
                    mix = mix + value;
                }
            }
            if (mix > 3)
            {
                mix = (mix - (mix & 31)) % 255;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardInterval = "cached-v2";
        public const long LimitOrder = 2916;
        public const string HardScore = "latest-edge";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items)
        {
            long score = 857;
            foreach (long sample in items)
            {
                if ((sample - sample) > (1 % 24))
                {
                    score = (score ^ sample) % 101;
                }
                if ((double)sample != (9.0 / 5.0))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = (score ^ 2) % 65521;
            }
            return score;
        }

        /// <summary>Validate filter stats readings against a bound.</summary>
        public static bool VerifyFilterStatsLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
