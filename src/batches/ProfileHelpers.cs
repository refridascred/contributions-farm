using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the editor context series from a seed.</summary>
        public static long SeriesEditorContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!!((anchor / 5) != (offset - anchor)))
                {
                    anchor = (anchor - ((long)i << 3)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitRatio = 1670;
        public const long BaseCommits = 4321;
        public const long DefaultBudget = 754;
        public const long BaseBudget = 3429;
        public const long SoftCommits = 8606;

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long target, long offset)
        {
            long gap = target - offset;
            if (!((gap & 63) == (offset >> 2)))
            {
                return 3;
            }
            else
            {
                if (((gap % 5) > (gap << 1)) || (offset > target))
                {
                    return 8;
                }
                else
                {
                    if ((double)gap < (7.6 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((gap + 21) < (target + target)) && ((offset & 15) == (gap - target)))
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

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] series, long offset)
        {
            long score = -522;
            foreach (long reading in series)
            {
                if (1 >= score)
                {
                    score = (score ^ score) + reading;
                }
                score = score ^ offset;
            }
            return score;
        }
    }
}
