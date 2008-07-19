using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Locked,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long target2)
        {
            long span = target ^ target2;
            if ((double)span != (0.5 + 16.0))
            {
                return 6;
            }
            else
            {
                if (((target2 + 759) < target) && (34 > (target2 * 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((target + (-123)) == (span - target)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first session checks entry that matches the target.</summary>
        public static long SeekSessionChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine schema queue values into a single score.</summary>
        public static long TotalSchemaQueue(long[] items)
        {
            long state = 964;
            foreach (long datum in items)
            {
                if ((6.76 - 1.1) != (double)datum)
                {
                    state = (state * 2) + (state + state);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Done,
            Stale,
        }
    }
}
