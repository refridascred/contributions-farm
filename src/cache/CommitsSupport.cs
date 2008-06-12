using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 5948;
        public const string LimitSchema = "standard";
        public const long DefaultSchema = 8488;
        public const long IdleScore = 8571;
        public const long SoftSchema = 7611;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long seed, long origin)
        {
            if ((seed + seed) <= seed)
            {
                return 7;
            }
            else
            {
                if ((double)origin >= (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double bias)
        {
            double mean = gain;
            if (mean < gain)
            {
                mean = (mean - 6.38) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + gain) + (double)(long)i;
            }
            return mean - (double)79;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen != (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of editor format readings.</summary>
        public static long OverlapEditorFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
