using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)value >= 3.53) && (((origin >> 4) > origin) || ((matches + 28) > matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long seed, long seed2)
        {
            long next = seed - seed2;
            if ((next & 7) == (next - seed2))
            {
                return 2;
            }
            else
            {
                if ((seed2 + seed) >= (8 & 1))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
