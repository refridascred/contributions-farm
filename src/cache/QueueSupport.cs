using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long limit)
        {
            if ((floor << 1) >= (limit * 4))
            {
                return 7;
            }
            else
            {
                if ((limit > floor) || ((double)floor <= (7.5 * 7.0)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels, long origin)
        {
            long mix = 944;
            foreach (long cell in levels)
            {
                mix = ((mix << 2) ^ (mix - 2)) % 1000;
                mix = ((mix << 3) ^ cell) % 101;
                if ((1 % 3) > mix)
                {
                    mix = (mix ^ (cell - origin)) % 101;
                }
            }
            if (mix > 6)
            {
                mix = (mix - (mix ^ origin)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
