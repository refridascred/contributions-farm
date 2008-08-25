using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((bound + hits) != ((long)values.Length / 8)) || ((cell + (-8)) != (hits + 524))) || ((hits * 2) >= (bound + 21)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long target, long origin)
        {
            if (origin >= (origin ^ origin))
            {
                return 4;
            }
            else
            {
                if ((8.2 / 3.0) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
