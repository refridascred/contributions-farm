using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] data, long step)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((((anchor * 3) + (anchor % 60)) + (long)i) + reading) + step;
                }
                if (((double)anchor < (4.2 * 2.9)) && ((anchor & 1) == (847 & 31)))
                {
                    anchor = anchor + (anchor & 127);
                }
                else
                {
                    anchor = anchor ^ (463 * 4);
                }
            }
            if (anchor > 259)
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor;
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
