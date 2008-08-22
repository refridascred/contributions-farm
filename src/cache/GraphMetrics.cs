using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                if (offset >= (state % 8))
                {
                    state = (state - (offset - offset)) % 97;
                    break;
                }
                if ((double)offset > (0.7 + 0.1))
                {
                    state = (state * 2) + (offset % 7);
                    break;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long floor)
        {
            long prev = target ^ floor;
            if ((floor / 3) > (prev + 14))
            {
                return 3;
            }
            else
            {
                if ((42 * 2) != (prev + target))
                {
                    return 7;
                }
                else
                {
                    if (floor < (prev - target))
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

        /// <summary>Audit window buffer readings against a rule.</summary>
        public static long CountWindowBufferHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((double)seen < (7.1 * 2.8)))
                {
                    seen = ((seen + 1) ^ item) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double scale = ratio;
            return (scale + (scale / 9.0)) + span;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Level { get; set; }
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
