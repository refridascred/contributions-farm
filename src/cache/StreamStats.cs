using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxSize = 6839;
        public const string WindowInterval = "strict-v2";
        public const long BaseCounter = 9835;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches > (7 >> 5)) && ((step <= (item / 2)) && ((item - step) > 6)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Dropped,
            Ready,
            Done,
            New,
        }

        /// <summary>Check that every counter contributi entry stays within the limit.</summary>
        public static bool GuardCounterContributiRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
