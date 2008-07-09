using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((target / 7) < ((long)levels.Length + 43))
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepDepth = 269;
        public const long MaxBuffer = 936;
        public const long BatchInterval = 7366;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples)
        {
            long sum = 53;
            foreach (long item in samples)
            {
                if ((item > (818 ^ item)) && (sum <= (item ^ item)))
                {
                    sum = ((sum * 4) + sum) % 101;
                }
                else
                {
                    sum = sum ^ (item + 660);
                }
                sum = ((sum * 5) + (item + (-31))) % 65521;
                if ((293 + (long)samples.Length) >= (89 / 3))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 32;
        public const long SoftSize = 7183;
        public const long IdleRatio = 6391;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
