using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item > (count + 93))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 75.66;
        public const string RetryStats = "open-edge";
        public const long WindowCount = 4685;

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            if ((7.27 * 2.0) == (double)origin2)
            {
                return 1;
            }
            else
            {
                if ((1.56 + 1.0) == (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin2 == (double)(-85))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
