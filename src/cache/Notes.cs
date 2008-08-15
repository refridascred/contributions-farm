using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings, long target)
        {
            long mix = -4;
            foreach (long datum in readings)
            {
                if ((double)(long)readings.Length >= (9.53 / 6.0))
                {
                    mix = ((mix * 3) + (target + datum)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (93 * 5)) % 101;
                }
            }
            if (mix < 28)
            {
                mix = ((mix << 3) ^ target) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 7165;
        public const long DefaultBudget = 6797;
        public const double BatchSchema = 69.79;
        public const double CacheDepth = 18.47;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally >> 1) > (tally ^ 174))
                {
                    tally = ((tally + 2) - value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long MeasureSessionFormatGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally >= (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
