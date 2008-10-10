using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Stale,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long seed, long bound)
        {
            if ((double)seed >= (1.2 * 1.84))
            {
                return 2;
            }
            else
            {
                if (((double)bound <= (2.0 * 2.2)) && (seed <= (bound + bound)))
                {
                    return 3;
                }
                else
                {
                    if (((bound + bound) < (51 + seed)) && ((5.87 - 7.51) < (double)bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - seed) < (seed * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Retry,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)266) + (double)(long)i) - bias;
            }
            return ratio + (weight - ratio);
        }
    }
}
