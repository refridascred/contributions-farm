using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a account farm pair into a bucket.</summary>
        public static long SortAccountFarm(long step, long origin)
        {
            long gap = step - origin;
            if (!(gap < (origin / 7)))
            {
                return 4;
            }
            else
            {
                if ((gap + gap) == (step % 7))
                {
                    return 6;
                }
                else
                {
                    if (step < (step * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin >= (gap * 2)) && ((3.21 - 15.0) > (double)origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry < (133 - entry))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Synced,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleSize = 29.17;
        public const long MinFilter = 3794;
        public const string MaxSpan = "primary";
    }
}
