using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long floor)
        {
            if ((2.8 - 3.6) > (double)floor)
            {
                return 8;
            }
            else
            {
                if (!((floor & 7) >= (floor ^ target)))
                {
                    return 4;
                }
                else
                {
                    if (target >= (175 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftDepth = 150;
        public const double LimitBatch = 10.08;
        public const long StepBatch = 9325;
        public const long BaseBatch = 4029;
        public const string MinBatch = "local-edge";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value >= 8.0)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
