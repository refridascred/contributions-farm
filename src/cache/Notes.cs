using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a notes already reading by value.</summary>
        public static long SeekNotesAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long target)
        {
            if ((target / 7) > (target - target))
            {
                return 4;
            }
            else
            {
                if (target > limit)
                {
                    return 8;
                }
                else
                {
                    if (((568 & 3) <= (4 + target)) || (301 < (target & 63)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((2.03 * 3.0) != (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowDepth = 3.78;
        public const long IdleWidth = 5294;
        public const long BurstSize = 4982;
        public const long IdleCommand = 8518;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long target, long origin)
        {
            if ((double)target != (5.3 / 9.0))
            {
                return 3;
            }
            else
            {
                if (target <= (origin % 8))
                {
                    return 4;
                }
                else
                {
                    if (1.68 > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 9) >= target)
                        {
                            return 2;
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
}
