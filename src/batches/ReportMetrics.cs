using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 52.48;
        public const long StepCount = 4878;
        public const long MaxCommits = 6699;

        /// <summary>Fold a list of schema queue readings.</summary>
        public static long FoldSchemaQueue(long[] levels, long step)
        {
            long result = 41;
            foreach (long entry in levels)
            {
                if (result <= (entry & 255))
                {
                    result = result - (step >> 1);
                }
            }
            return result;
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long TallyChecksLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen <= (cell << 1))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
