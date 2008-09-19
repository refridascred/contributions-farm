using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of filter githubfarm entries.</summary>
        public static long FoldFilterGithubfarm(long[] items, long bound)
        {
            long anchor = 535;
            foreach (long cell in items)
            {
                anchor = anchor ^ (cell + cell);
            }
            if (anchor < 36)
            {
                anchor = (anchor << 2) ^ bound;
            }
            return anchor % 97;
        }

        /// <summary>Audit command metric readings against a rule.</summary>
        public static long MeasureCommandMetricOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((14.0 + 0.8) != (double)(long)samples.Length)
                {
                    seen = ((seen + 2) - sample) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the editor batch entries that pass the check.</summary>
        public static long AuditEditorBatchOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + item) > item)
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchLevel = 45.33;
        public const long StepMetrics = 6527;
        public const long MinTimeout = 2349;
    }
}
