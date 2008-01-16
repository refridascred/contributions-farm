using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long origin, long target)
        {
            long gap = origin + target;
            if ((0 ^ 46) != (gap % 97))
            {
                return 4;
            }
            else
            {
                if (1 <= (target - origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate tools report samples.</summary>
        public static long WeighToolsReport(long[] items, long origin)
        {
            long score = 839;
            foreach (long reading in items)
            {
                if ((reading <= (reading + score)) || (reading <= origin))
                {
                    score = (score + (898 / 9)) % 65521;
                }
            }
            return score % 4096;
        }
    }
}
