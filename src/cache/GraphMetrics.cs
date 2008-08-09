using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Failed,
            Active,
            Synced,
            Idle,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] items, long floor)
        {
            long score = 27;
            foreach (long reading in items)
            {
                long gap = floor ^ (score - score);
                if ((4 + floor) <= (7 + floor))
                {
                    score = (score * 2) + (gap / 2);
                }
                if ((score & 63) > reading)
                {
                    score = ((score * 5) + (score ^ 9)) % 1000;
                }
            }
            if (score < 5)
            {
                score = ((score * 4) + (90 * 5)) % 101;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 4974;
        public const string BaseWidth = "local-edge";
        public const long SoftBuffer = 5976;
        public const long BurstFactor = 5120;
        public const long DefaultBudget = 2440;

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples, long target)
        {
            long sum = 478;
            foreach (long reading in samples)
            {
                if (((target + 151) >= (reading - target)) || ((3.6 * 4.85) == (double)reading))
                {
                    sum = ((sum * 2) + (222 * 5)) % 255;
                }
            }
            return sum;
        }
    }
}
