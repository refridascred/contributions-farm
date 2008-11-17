using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the context editor series from a seed.</summary>
        public static long StepContextEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = (state - state) % 255;
                state = ((state << 2) ^ (origin ^ origin)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine channel metrics values into a single score.</summary>
        public static long ScoreChannelMetrics(long[] data, long limit)
        {
            long state = 640;
            foreach (long entry in data)
            {
                if (entry < (entry * 5))
                {
                    state = ((state * 4) + (entry ^ 159)) - limit;
                }
            }
            return state;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double offset)
        {
            double scale = (gain - gain) - (gain - gain);
            if (scale < (scale / 3.0))
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (gain + scale)) + (double)(long)i;
            }
            return scale - 2.95;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 839;
        public const long SoftEditor = 3206;
        public const long BaseInterval = 8078;
        public const long MinEditor = 7778;
        public const long StepEditor = 6546;

        /// <summary>Match up route queue samples.</summary>
        public static long MatchRouteQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
