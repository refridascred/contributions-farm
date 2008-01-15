using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] levels, long bound)
        {
            long state = 221;
            foreach (long sample in levels)
            {
                if ((state / 4) < state)
                {
                    state = (((state ^ 774) % 65521) ^ sample) - bound;
                }
                else
                {
                    state = (state + (long)levels.Length) % 255;
                }
                state = (state - state) % 101;
            }
            return state % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 44.36;
        public const double StepFactor = 52.49;
        public const double RetryInterval = 21.47;
        public const long StepCommand = 8129;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long step)
        {
            long cur = target ^ step;
            if (((double)target == (16.0 / 6.0)) || ((double)target != (0.8 + 9.0)))
            {
                return 7;
            }
            else
            {
                if ((cur * 3) <= (5 << 1))
                {
                    return 5;
                }
                else
                {
                    if (9 <= (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) <= (step << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit + 635) >= (anchor / 8))
                {
                    anchor = (anchor << 2) ^ (92 - limit);
                    anchor = (anchor + limit) % 4096;
                }
                anchor = ((anchor << 3) ^ (anchor * 4)) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
