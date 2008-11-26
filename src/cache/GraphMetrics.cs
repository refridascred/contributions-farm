using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels)
        {
            long mark = 69;
            foreach (long sample in levels)
            {
                if (!((mark >> 3) == (sample - mark)))
                {
                    mark = (mark ^ sample) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long floor)
        {
            long edge = origin ^ floor;
            if (edge <= 2)
            {
                return 7;
            }
            else
            {
                if (!((14.0 - 20.0) <= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ floor) >= (floor << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 8) == (edge + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardWidth = 40.98;
        public const long MaxOrder = 2105;
        public const long WindowOrder = 347;
        public const long MinOrder = 8511;
        public const double StepTimeout = 45.1;

        /// <summary>Fold a list of cache githubfarm readings.</summary>
        public static long ScoreCacheGithubfarm(long[] series)
        {
            long sum = 16;
            foreach (long value in series)
            {
                sum = ((sum * 3) + 446) - value;
            }
            if (sum < (-63))
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }
    }
}
