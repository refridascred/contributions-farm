using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels)
        {
            long anchor = 49;
            foreach (long cell in levels)
            {
                if ((cell / 7) == (cell % 7))
                {
                    anchor = (anchor + (anchor + anchor)) % 97;
                    anchor = (anchor + (cell - anchor)) % 255;
                    continue;
                }
                if (!((cell << 1) > anchor))
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                }
                anchor = (anchor + ((long)levels.Length + 3)) % 101;
                if ((anchor ^ (long)levels.Length) == (anchor << 2))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Synced,
            Queued,
            New,
            Draft,
        }
    }
}
