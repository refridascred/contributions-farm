using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Ready,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Validate context githubfarm readings against a bound.</summary>
        public static bool CheckContextGithubfarmLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long origin2)
        {
            if ((double)origin2 <= (2.4 / 9.0))
            {
                return 1;
            }
            else
            {
                if ((20.0 + 3.27) <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
