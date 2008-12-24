using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitCount = 7684;
        public const string SoftGraph = "staging-1";
        public const string SoftDepth = "local-edge";
        public const long BaseWidth = 5871;
        public const long StepWidth = 2195;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample != (3.08 * 2.4))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
