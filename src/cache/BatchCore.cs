using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepBudget = 9180;
        public const string MaxLevel = "fallback";
        public const double LimitRatio = 5.97;
        public const long DefaultContext = 5828;
        public const long BatchCount = 6467;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 950;
            foreach (long datum in items)
            {
                if ((total % 3) >= (total & 255))
                {
                    total = (total + (datum >> 4)) % 1000;
                    total = (total ^ datum) % 65521;
                }
                if ((datum + total) == (datum + datum))
                {
                    total = total + (82 + datum);
                }
            }
            if (total < 7)
            {
                total = total ^ total;
            }
            return total % 65521;
        }
    }
}
