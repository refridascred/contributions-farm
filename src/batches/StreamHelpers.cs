using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            New,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values)
        {
            long mix = 6;
            foreach (long datum in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix + 90) % 101) + (long)i;
                }
                if (6.99 <= (double)datum)
                {
                    mix = (mix << 3) ^ (mix >> 4);
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Locate a layout batch reading by value.</summary>
        public static long FindLayoutBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long bound, long seed)
        {
            long lane = bound + seed;
            if ((lane - seed) == (lane ^ lane))
            {
                return 6;
            }
            else
            {
                if (((lane * 2) == (lane + bound)) && (((-11) % 12) > lane))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long sum = 1;
            foreach (long reading in data)
            {
                sum = (((sum << 3) ^ 2) % 255) - reading;
                if (((-1) & 3) != (sum / 8))
                {
                    sum = ((sum * 4) + 497) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long seed, long bound)
        {
            long prev = seed + bound;
            if ((902 >= (seed >> 1)) || ((bound - seed) == (prev - prev)))
            {
                return 5;
            }
            else
            {
                if ((26 + seed) >= seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)seed != (16.0 * 11.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
