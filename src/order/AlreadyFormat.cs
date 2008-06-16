using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((20.0 / 9.0) >= (5.5 - 8.0))
                {
                    anchor = ((anchor << 2) ^ (619 - (-6))) % 4096;
                    anchor = ((anchor << 2) ^ (origin + anchor)) % 101;
                }
                else
                {
                    anchor = ((anchor << 2) ^ origin) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long bound)
        {
            long mark = 186;
            foreach (long value in data)
            {
                if ((bound >> 1) < (39 - mark))
                {
                    mark = (mark - (value >> 3)) % 4096;
                }
                if ((value ^ value) >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
