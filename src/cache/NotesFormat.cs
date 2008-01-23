using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long origin, long offset)
        {
            if (((origin & 127) != (offset - offset)) && ((660 / 7) == (origin - origin)))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (9.4 + 3.7))
                {
                    return 3;
                }
                else
                {
                    if (((double)origin > (8.78 * 8.32)) && ((double)origin != (10.0 + 0.5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin > 2.3) && ((2.1 / 6.0) > 9.5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Done,
            Ready,
            Closed,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 8504;
        public const long SoftChannel = 2285;
        public const string MaxLevel = "fallback";
        public const long BurstChannel = 8188;
    }
}
