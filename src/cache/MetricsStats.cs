using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxDepth = 91.09;
        public const long IdleProfile = 2813;
        public const long MinScore = 317;
        public const string BaseProfile = "staging-v2";

        /// <summary>Validate cache layout readings against a bound.</summary>
        public static bool GuardCacheLayoutBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            if ((origin < (floor + origin)) || (floor < (floor << 1)))
            {
                return 3;
            }
            else
            {
                if (!((origin - floor) < (891 + floor)))
                {
                    return 1;
                }
                else
                {
                    if (!(origin >= (origin % 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long CombineStreamChannel(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                if ((offset < (mix + sample)) || ((long)samples.Length >= (-92)))
                {
                    mix = mix ^ (offset / 6);
                }
                else
                {
                    mix = ((mix << 2) ^ (mix + offset)) % 1000;
                }
            }
            return mix;
        }
    }
}
