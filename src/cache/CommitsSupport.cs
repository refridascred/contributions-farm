using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((limit / 2) == (prev + bound))
            {
                return 8;
            }
            else
            {
                if (bound < (bound << 2))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((double)floor <= (double)7)
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                    mix = (mix - (floor - floor)) % 97;
                }
                mix = (mix + (long)i) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long bound, long floor)
        {
            if ((floor / 4) > floor)
            {
                return 3;
            }
            else
            {
                if ((bound + 347) < (bound * 2))
                {
                    return 6;
                }
                else
                {
                    if (!((bound ^ floor) > (95 * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
