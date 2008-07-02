using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long bound2)
        {
            if ((-83) <= (bound + bound2))
            {
                return 3;
            }
            else
            {
                if ((bound2 + 76) != (54 * 4))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound2) >= bound2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) >= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] items, long floor)
        {
            long result = 1;
            foreach (long datum in items)
            {
                if ((datum ^ 0) != (long)items.Length)
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result > 507)
            {
                result = (result * 3) + (result + floor);
            }
            return result;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
