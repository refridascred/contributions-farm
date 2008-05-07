using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheWidth = 1685;
        public const long LimitProfile = 6459;
        public const string BatchDepth = "open-1";
        public const long WindowProfile = 479;
        public const long HardProfile = 9260;

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long seed, long step)
        {
            if (2.4 < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed & 7) > seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed * 5) > step)
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

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseCount = 23.56;
        public const long MaxLayout = 713;
        public const long MinCount = 3526;
    }
}
