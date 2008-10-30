using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((hits * 5) >= (843 % 10)) && ((9.14 * 9.66) < (double)limit)) || ((double)limit <= 2.3))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long bound2)
        {
            if ((bound2 ^ bound) != (bound >> 2))
            {
                return 3;
            }
            else
            {
                if ((double)bound2 < (5.2 + 6.9))
                {
                    return 2;
                }
                else
                {
                    if ((69 - bound2) >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((bound2 & 15) == (582 / 5)))
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

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long step, long step2)
        {
            long lane = step - step2;
            if ((step * 2) == (step + step2))
            {
                return 5;
            }
            else
            {
                if ((lane + step2) >= (step + step))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
