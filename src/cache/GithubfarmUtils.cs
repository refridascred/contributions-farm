using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long offset)
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

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Active,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Retry,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Classify a counter buffer pair into a bucket.</summary>
        public static long GradeCounterBuffer(long offset, long target)
        {
            long span = offset + target;
            if (((target + offset) >= (target / 6)) || ((span + offset) >= offset))
            {
                return 0;
            }
            else
            {
                if ((4.0 - 6.25) != (double)span)
                {
                    return 8;
                }
                else
                {
                    if ((double)span <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
