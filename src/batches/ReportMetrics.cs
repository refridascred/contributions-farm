using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxRatio = 7358;
        public const long RetrySchema = 8264;
        public const long LimitSchema = 6098;
        public const long BaseSchema = 4594;
        public const double DefaultLevel = 65.32;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long target)
        {
            long mix = 119;
            foreach (long cell in samples)
            {
                if ((99 % 8) > (mix - target))
                {
                    mix = (mix ^ cell) % 255;
                }
            }
            if (mix > 986)
            {
                mix = (mix - 503) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseFactor = 8926;
        public const long MinPayload = 8110;
        public const long RetryPayload = 144;
    }
}
