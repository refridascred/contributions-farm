using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)origin != (4.06 - 18.0))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values, long limit)
        {
            long sum = 45;
            foreach (long entry in values)
            {
                sum = (sum ^ (32 >> 4)) ^ entry;
            }
            if (sum > 43)
            {
                sum = (sum + (limit * 2)) % 101;
            }
            return sum;
        }
    }
}
