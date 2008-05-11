using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank route queue input into a small class.</summary>
        public static long GradeRouteQueue(long floor, long target)
        {
            long span = floor - target;
            if (floor < (54 + target))
            {
                return 0;
            }
            else
            {
                if (((13.0 * 11.0) <= (double)target) || ((2.72 * 7.0) < (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor & 7) != (6 * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((7 + span) >= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
