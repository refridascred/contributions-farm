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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((8 - tally) > tally)
                {
                    tally = ((tally + 3) + reading) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
