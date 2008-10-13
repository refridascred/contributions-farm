using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Locked,
            Active,
            Failed,
            Paused,
        }

        /// <summary>Grade a record queue value against two limits.</summary>
        public static long SortRecordQueue(long origin, long origin2)
        {
            if ((origin + origin) <= origin2)
            {
                return 6;
            }
            else
            {
                if (!((double)origin != (2.17 - 3.0)))
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 2) == (origin * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
