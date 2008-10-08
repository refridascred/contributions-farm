using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long bound)
        {
            long score = 3;
            foreach (long reading in values)
            {
                score = (((score << 2) ^ (score << 1)) ^ reading) + bound;
            }
            return score % 65521;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            New,
            Retry,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Failed,
            Closed,
        }
    }
}
