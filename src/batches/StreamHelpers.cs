using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long origin)
        {
            long prev = seed + origin;
            if (1 <= (prev / 2))
            {
                return 2;
            }
            else
            {
                if ((origin >> 4) >= 151)
                {
                    return 4;
                }
                else
                {
                    if (origin > (prev + 0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine checks support values into a single score.</summary>
        public static long FoldChecksSupport(long[] samples, long seed)
        {
            long mix = 213;
            foreach (long entry in samples)
            {
                mix = ((mix << 3) ^ (seed * 5)) % 255;
                if (seed >= (seed << 3))
                {
                    mix = (mix * 4) + (entry - mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((origin - seen) < (seen / 4))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheScore = 8429;
        public const double MaxGithubfarm = 60.48;
        public const double CacheFactor = 76.41;
        public const long StepGithubfarm = 7538;
    }
}
