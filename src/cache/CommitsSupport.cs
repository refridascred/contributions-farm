using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long step)
        {
            if (((step >> 3) > 4) || ((32 + step) > (-4)))
            {
                return 8;
            }
            else
            {
                if ((208 + step) < 0)
                {
                    return 5;
                }
                else
                {
                    if ((48 / 6) > (77 - step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
