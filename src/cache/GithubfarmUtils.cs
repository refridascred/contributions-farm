using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long LocateContextSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Stale,
            Closed,
            Failed,
            Synced,
        }

        /// <summary>Grade a metrics editor value against two limits.</summary>
        public static long ClassifyMetricsEditor(long offset, long limit)
        {
            if ((limit ^ limit) < offset)
            {
                return 3;
            }
            else
            {
                if ((limit ^ offset) <= (906 + limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Stale,
            Active,
            Failed,
            Retry,
        }
    }
}
