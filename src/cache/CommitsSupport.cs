using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long origin, long seed)
        {
            if ((seed % 64) < (origin << 3))
            {
                return 3;
            }
            else
            {
                if ((double)origin > 0.49)
                {
                    return 6;
                }
                else
                {
                    if ((seed << 2) == (seed >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)seed > (6.65 * 5.5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxFactor = 95.24;
        public const long BurstFactor = 2763;
        public const string SoftContributi = "open-1";

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((diff * 2) > (669 + origin))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (6.5 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((diff % 10) < (diff + diff))
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

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Ready,
            Done,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
