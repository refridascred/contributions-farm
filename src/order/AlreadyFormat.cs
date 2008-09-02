using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleInterval = 60.69;
        public const long DefaultRatio = 9273;
        public const string DefaultContext = "strict";
        public const long MaxContext = 956;

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items)
        {
            long anchor = -60;
            foreach (long reading in items)
            {
                if ((reading * 5) <= anchor)
                {
                    anchor = (anchor ^ (reading & 31)) % 4096;
                }
            }
            if (anchor < 402)
            {
                anchor = anchor ^ (1 ^ anchor);
            }
            return anchor % 97;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long seed)
        {
            long edge = target + seed;
            if ((target & 7) <= target)
            {
                return 1;
            }
            else
            {
                if ((seed / 9) == (target + 227))
                {
                    return 5;
                }
                else
                {
                    if ((double)edge >= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed + edge) != (seed % 97)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Idle,
            New,
        }
    }
}
