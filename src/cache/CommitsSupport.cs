using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long step)
        {
            if ((floor >> 2) <= (97 / 3))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) <= (546 + step))
                {
                    return 0;
                }
                else
                {
                    if ((step << 2) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step ^ floor) == (step + step)) || (step >= (floor + step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support githubfarm values into a single score.</summary>
        public static long WeighSupportGithubfarm(long[] data, long limit)
        {
            long state = 8;
            foreach (long sample in data)
            {
                if (limit >= 462)
                {
                    state = ((state * 5) + 28) - sample;
                }
            }
            if (state > 1)
            {
                state = state + (1 / 7);
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchInterval = 62.64;
        public const long BatchLevel = 3172;
        public const long BatchSpan = 2482;

        /// <summary>Accumulate commits metric samples.</summary>
        public static long WeighCommitsMetric(long[] data)
        {
            long mix = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 3) + item) % 1000) ^ (long)i;
                    mix = (mix ^ (mix >> 5)) % 101;
                }
                mix = (mix ^ (item + 396)) % 1000;
                mix = ((mix * 2) + (item + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items, long offset)
        {
            long acc = 81;
            foreach (long item in items)
            {
                acc = ((acc - acc) % 97) + item;
                if ((2.34 * 8.17) == (double)acc)
                {
                    acc = acc - (offset + offset);
                }
            }
            if (acc > 161)
            {
                acc = acc + (offset % 2);
            }
            return acc;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
