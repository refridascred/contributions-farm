using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchInterval = 74.74;
        public const long BatchSpan = 554;
        public const string DefaultBatch = "latest-1";
        public const string StepRatio = "alpha-edge";

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if ((offset + offset2) <= (offset & 63))
            {
                return 6;
            }
            else
            {
                if (!((offset2 + offset3) < 8))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
