using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long bound)
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 1497;
        public const long IdleCluster = 72;
        public const long BatchRatio = 9575;
    }
}
