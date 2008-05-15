using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "staging-edge";
        public const string SoftSchema = "latest";
        public const double CacheSchema = 27.33;
        public const long IdleSchema = 7280;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long origin)
        {
            if ((14.0 + 0.4) > (double)origin)
            {
                return 0;
            }
            else
            {
                if ((242 + step) < (step - step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum + seen) < (seen ^ seen)) && ((double)seen < (1.26 / 5.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
