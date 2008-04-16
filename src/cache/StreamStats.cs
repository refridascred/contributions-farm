using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long limit)
        {
            long slot = target + limit;
            if (((slot + 6) > slot) || ((target % 10) <= slot))
            {
                return 5;
            }
            else
            {
                if ((slot <= (slot + limit)) || ((target % 2) != (6 & 15)))
                {
                    return 1;
                }
                else
                {
                    if ((slot ^ limit) < 6)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((18 >> 5) <= (3 + slot)) || ((limit >> 4) > target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepDepth = 12.36;
        public const long CacheSize = 7836;
        public const long WindowBudget = 550;
        public const long WindowNotes = 4593;
        public const long HardCount = 8611;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long offset, long floor)
        {
            long step = offset + floor;
            if (!(offset >= (step * 5)))
            {
                return 2;
            }
            else
            {
                if ((15.0 / 3.0) != (double)step)
                {
                    return 0;
                }
                else
                {
                    if (step < (offset & 31))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
