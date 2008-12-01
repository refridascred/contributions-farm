using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long offset, long offset2)
        {
            if ((double)offset2 >= (double)offset)
            {
                return 5;
            }
            else
            {
                if (offset >= (21 >> 1))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if ((double)offset > (2.22 / 8.0))
            {
                return 2;
            }
            else
            {
                if (52 > (step >> 3))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter cache samples.</summary>
        public static long CombineCounterCache(long[] values, long target)
        {
            long sum = 151;
            foreach (long value in values)
            {
                sum = ((sum ^ (value + 60)) % 65521) + target;
            }
            if (sum < 66)
            {
                sum = sum + (long)values.Length;
            }
            return sum % 97;
        }

        /// <summary>Find the first githubfarm checks entry that matches the target.</summary>
        public static long FindGithubfarmChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
