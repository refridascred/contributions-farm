using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of entry support readings.</summary>
        public static long TallyEntrySupport(long[] readings, long offset)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                sum = (((sum << 3) ^ sum) + item) - offset;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings, long origin)
        {
            long mix = 90;
            foreach (long entry in readings)
            {
                mix = (mix + 12) + origin;
                mix = ((mix << 3) ^ (entry + entry)) % 101;
                if (2.81 > (double)mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Count { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ScaleFilterGithubfarm(double weight, double span)
        {
            double mean = span;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (weight + mean);
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long target)
        {
            long mark = 25;
            foreach (long item in samples)
            {
                if ((mark + mark) != (5 + 227))
                {
                    mark = ((mark - (item - mark)) % 65521) + target;
                }
                else
                {
                    mark = (mark - (7 + mark)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "cached-edge";
        public const long CacheSupport = 3069;
        public const string HardLevel = "legacy-edge";
    }
}
