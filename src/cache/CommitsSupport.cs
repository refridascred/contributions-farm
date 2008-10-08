using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank route filter input into a small class.</summary>
        public static long BucketRouteFilter(long offset, long limit)
        {
            if ((offset - limit) != (offset + offset))
            {
                return 8;
            }
            else
            {
                if ((limit >> 3) >= (limit - limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit > 8.2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit % 24) != (limit + 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
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

        /// <summary>Roll a buffer batch counter forward.</summary>
        public static long SeriesBufferBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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
