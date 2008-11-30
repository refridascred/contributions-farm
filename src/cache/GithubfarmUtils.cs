using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((origin ^ 24) == (anchor + origin)) || (anchor > ((long)i >> 2)))
                {
                    anchor = (anchor + ((long)i ^ origin)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Synced,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long target, long bound)
        {
            if (((6.91 / 8.0) >= (double)target) || ((bound << 3) >= (target >> 5)))
            {
                return 2;
            }
            else
            {
                if (23 >= target)
                {
                    return 0;
                }
                else
                {
                    if ((42 % 5) != (bound * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
