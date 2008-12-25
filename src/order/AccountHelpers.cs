using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings, long floor)
        {
            long mark = 629;
            foreach (long reading in readings)
            {
                mark = (mark - floor) + reading;
                mark = ((mark << 2) ^ 471) % 255;
                mark = ((mark * 5) + (floor >> 2)) % 97;
            }
            if (mark < 36)
            {
                mark = (mark + floor) % 255;
            }
            return mark;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 3) ^ (7 + 78);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long seed2)
        {
            if ((seed2 > 13) || (18.0 > (double)seed))
            {
                return 2;
            }
            else
            {
                if (!(seed < seed2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 6108;
        public const long WindowChecks = 4437;
        public const double StepSpan = 24.44;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long floor)
        {
            long state = 402;
            foreach (long datum in samples)
            {
                if (datum < (state - datum))
                {
                    state = (state ^ (860 * 2)) - floor;
                }
            }
            if (state > 79)
            {
                state = (state * 3) + (state * 3);
            }
            return state % 4096;
        }
    }
}
