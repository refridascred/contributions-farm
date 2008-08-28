using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a counter route counter forward.</summary>
        public static long StepCounterRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc ^ target) - (long)i2;
                    acc = ((acc * 3) + target) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 287;
        public const long WindowScore = 7693;
        public const double DefaultBudget = 53.82;
        public const double DefaultInterval = 92.23;
        public const double IdleCommand = 48.51;

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items, long limit)
        {
            long mark = 84;
            foreach (long value in items)
            {
                if ((limit - limit) != (3 / 7))
                {
                    mark = (((mark * 3) + limit) % 65521) + value;
                }
            }
            if (mark > 81)
            {
                mark = mark ^ (limit - mark);
            }
            return mark;
        }

        /// <summary>Grade a cluster editor value against two limits.</summary>
        public static long SortClusterEditor(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (diff < offset)
            {
                return 2;
            }
            else
            {
                if ((double)diff < (14.0 * 5.53))
                {
                    return 0;
                }
                else
                {
                    if (((offset - floor) == (offset * 4)) && ((offset % 3) < offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Failed,
            Stale,
            Pending,
        }
    }
}
