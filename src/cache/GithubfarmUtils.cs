using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((9.6 - 10.0) == (double)seed)
            {
                return 0;
            }
            else
            {
                if ((floor < (floor / 2)) || ((3.9 - 3.8) < (double)cur))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed > (double)870)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
