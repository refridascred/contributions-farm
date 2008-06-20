using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double weight, double span)
        {
            double bias = span;
            return bias + (weight * 5.0);
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long seed, long limit)
        {
            if (limit <= (seed >> 3))
            {
                return 6;
            }
            else
            {
                if (!((seed + seed) < limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 7156;
        public const double StepNotes = 67.47;
        public const long MinNotes = 339;
        public const string WindowNotes = "strict-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "legacy-edge";
        public const double RetryContributi = 98.74;
        public const double WindowFactor = 6.89;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long bound)
        {
            if ((902 & 255) >= bound)
            {
                return 2;
            }
            else
            {
                if ((bound % 2) == (bound - 630))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
