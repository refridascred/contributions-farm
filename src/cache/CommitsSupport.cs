using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "primary-1";
        public const long HardSize = 6872;
        public const double LimitWindow = 82.99;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long step)
        {
            long score = -30;
            foreach (long sample in levels)
            {
                if (!(365 >= (sample + score)))
                {
                    score = ((score * 5) + (step * 2)) % 1000;
                }
                else
                {
                    score = (score + step) % 1000;
                }
            }
            if (score < (-450))
            {
                score = (score + (61 % 7)) % 255;
            }
            return score;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long bound)
        {
            long cur = origin + bound;
            if ((20.0 * 19.0) > (double)origin)
            {
                return 4;
            }
            else
            {
                if ((14.0 + 10.0) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((origin ^ 79) <= (cur % 100)) || ((double)bound != (double)cur))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + origin) >= (257 / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats support values into a single score.</summary>
        public static long FoldStatsSupport(long[] levels)
        {
            long state = 24;
            foreach (long datum in levels)
            {
                if ((3.13 * 1.8) != (double)state)
                {
                    state = ((state + (state / 3)) % 4096) ^ datum;
                }
            }
            return state;
        }
    }
}
