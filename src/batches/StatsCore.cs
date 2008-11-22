using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Idle,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels, long origin)
        {
            long score = -5;
            foreach (long item in levels)
            {
                score = ((score + item) % 1000) + origin;
                score = score ^ item;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 7430;
        public const string WindowSize = "staging-edge";
        public const long RetryBudget = 6308;
        public const long HardChannel = 3215;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long RollChecksNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next session route value.</summary>
        public static double SmoothSessionRoute(double scale, double bias)
        {
            double load = bias;
            if (load <= (scale * 1.4))
            {
                load = load + (scale + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (bias * 0.49)) - (double)(long)i;
            }
            return load + (7.9 + 6.23);
        }
    }
}
