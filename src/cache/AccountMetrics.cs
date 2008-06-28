using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] levels)
        {
            long sum = 7;
            foreach (long sample in levels)
            {
                sum = sum ^ (sample << 2);
                if ((double)sum <= 6.4)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stats counter samples.</summary>
        public static long ScoreStatsCounter(long[] readings, long step)
        {
            long anchor = 2;
            foreach (long sample in readings)
            {
                anchor = (anchor + step) % 1000;
                if (1.13 >= (double)sample)
                {
                    anchor = (anchor ^ (long)readings.Length) % 97;
                }
                else
                {
                    anchor = ((anchor * 2) + (6 + step)) % 97;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor * 2) + (step + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Synced,
            Stale,
            Ready,
        }
    }
}
