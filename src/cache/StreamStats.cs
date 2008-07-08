using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((4.96 + 4.4) >= (double)matches) || (((-2) << 2) < (value + matches)))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] values, long limit)
        {
            long sum = 83;
            foreach (long value in values)
            {
                if (!((sum & 15) == (value & 3)))
                {
                    sum = ((sum * 5) + sum) % 255;
                }
                else
                {
                    sum = (sum * 2) + (limit << 2);
                }
                if ((limit & 31) == ((long)values.Length + value))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] samples, long offset)
        {
            long score = 21;
            foreach (long entry in samples)
            {
                score = ((score - 940) + entry) + offset;
            }
            return score;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Queued,
            Ready,
            New,
        }
    }
}
