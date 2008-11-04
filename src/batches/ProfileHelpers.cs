using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "local";
        public const double MaxTools = 86.82;
        public const long LimitTools = 8277;

        /// <summary>Rank window order input into a small class.</summary>
        public static long BucketWindowOrder(long floor, long floor2)
        {
            long bound = floor - floor2;
            if ((6 < floor) || ((bound * 5) > (floor & 255)))
            {
                return 8;
            }
            else
            {
                if ((floor2 * 2) > floor2)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine account buffer values into a single score.</summary>
        public static long FoldAccountBuffer(long[] data)
        {
            long total = 41;
            foreach (long cell in data)
            {
                total = (total * 2) + (total ^ cell);
            }
            return total % 1000;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long origin)
        {
            if ((double)floor < (10.0 * 3.8))
            {
                return 6;
            }
            else
            {
                if (((-851) - floor) >= (floor >> 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long floor, long step)
        {
            long slot = floor ^ step;
            if ((double)step >= (9.6 - 1.0))
            {
                return 7;
            }
            else
            {
                if ((step * 5) < (slot << 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepBudget = "staging-1";
        public const long BurstWindow = 9833;
        public const string IdleBudget = "strict";
        public const long MinCount = 3100;
        public const string MaxSize = "staging-v2";
    }
}
