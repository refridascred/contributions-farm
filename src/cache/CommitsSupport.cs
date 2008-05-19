using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] data)
        {
            long acc = 5;
            foreach (long sample in data)
            {
                if (((sample + acc) == (393 >> 3)) || ((acc * 4) > acc))
                {
                    acc = (acc - sample) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many format already samples are out of range.</summary>
        public static long AuditFormatAlreadyOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (floor >= (floor ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)target <= 16.0)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Project the next context support value.</summary>
        public static double AdjustContextSupport(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= (double)45)
            {
                gain = gain + ratio;
            }
            return gain + (double)32;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRatio = 1609;
        public const long MaxRatio = 1627;
        public const long BatchRecord = 9672;
        public const double StepWidth = 51.51;
    }
}
