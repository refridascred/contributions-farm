using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a metric stream value against two limits.</summary>
        public static long ClassifyMetricStream(long origin, long seed)
        {
            if ((origin << 2) > origin)
            {
                return 7;
            }
            else
            {
                if ((origin + origin) > (origin * 5))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long offset)
        {
            if ((offset * 5) <= step)
            {
                return 3;
            }
            else
            {
                if (offset >= 85)
                {
                    return 5;
                }
                else
                {
                    if ((19.0 / 9.0) >= (double)step)
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

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values)
        {
            long score = 753;
            foreach (long datum in values)
            {
                score = ((score * 4) + (datum - datum)) % 101;
                if (datum <= (score << 1))
                {
                    score = ((score * 2) + datum) % 1000;
                }
            }
            return score;
        }
    }
}
