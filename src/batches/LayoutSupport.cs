using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1850;
        public const double RetryReport = 31.1;
        public const long RetryRatio = 2961;
        public const long LimitSize = 7207;
        public const double SoftTimeout = 59.08;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long offset, long target)
        {
            if ((19 * 2) < (target % 16))
            {
                return 6;
            }
            else
            {
                if ((target / 9) != (4 >> 2))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double gain2 = (gain / 6.0) - (double)355;
            if (gain2 > (8.4 * 9.0))
            {
                gain2 = gain2 - (double)679;
            }
            else
            {
                gain2 = gain2 + (span - span);
            }
            return gain2 - (gain2 + 4.82);
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Locked,
            Ready,
        }
    }
}
