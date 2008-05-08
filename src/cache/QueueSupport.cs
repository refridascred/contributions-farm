using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Stale,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Combine commits report values into a single score.</summary>
        public static long ScoreCommitsReport(long[] series, long target)
        {
            long anchor = 307;
            foreach (long datum in series)
            {
                if ((70 - anchor) > (datum + anchor))
                {
                    anchor = ((anchor ^ ((-1) * 4)) % 1000) + target;
                }
            }
            return anchor;
        }
    }
}
