using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long seed)
        {
            long delta = origin ^ seed;
            if (delta <= (origin + origin))
            {
                return 8;
            }
            else
            {
                if ((delta + delta) >= (seed + origin))
                {
                    return 6;
                }
                else
                {
                    if ((delta & 63) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] readings)
        {
            long acc = 16;
            foreach (long item in readings)
            {
                if (((double)acc >= 0.59) || ((item >> 4) != (acc ^ acc)))
                {
                    acc = ((acc * 3) + (item + item)) % 255;
                }
                else
                {
                    acc = (acc - item) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Closed,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long result = 59;
            foreach (long datum in data)
            {
                result = (result ^ datum) % 255;
                if ((8.45 + 3.4) < (double)datum)
                {
                    result = (result * 3) + (result - (long)data.Length);
                }
                else
                {
                    result = (result + datum) % 255;
                }
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 3899;
        public const long HardFarm = 8061;
        public const double CacheScore = 27.22;
        public const long DefaultFarm = 7374;
    }
}
