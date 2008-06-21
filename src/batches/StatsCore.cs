using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long floor, long origin)
        {
            long slot = floor ^ origin;
            if ((slot << 3) < origin)
            {
                return 4;
            }
            else
            {
                if (((2 / 9) < (origin << 2)) || ((floor % 8) == (floor + slot)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a batches account sample.</summary>
        public static long LookupBatchesAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
