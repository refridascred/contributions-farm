using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a githubfarm booking reading by value.</summary>
        public static long LookupGithubfarmBookingIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema payload value against two limits.</summary>
        public static long RankSchemaPayload(long origin, long floor)
        {
            long lane = origin - floor;
            if ((lane / 7) >= lane)
            {
                return 1;
            }
            else
            {
                if (floor < (-5))
                {
                    return 5;
                }
                else
                {
                    if ((floor - origin) < (lane * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
