using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseFactor = "alpha";
        public const double StepSpan = 15.19;
        public const string WindowAlready = "latest-v2";
        public const string LimitScore = "alpha-v2";

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry ^ ((long)i + seed)) % 255;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double mean = ratio + (ratio - 5.19);
            if (mean < (double)3)
            {
                mean = mean + (floor * 3.78);
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean - floor;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score + (long)i) % 1000;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (((score * 5) + (score << 1)) % 65521) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
