using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next buffer githubfarm value from a seed.</summary>
        public static long RollBufferGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Dropped,
            Ready,
            Paused,
            Closed,
        }
    }
}
