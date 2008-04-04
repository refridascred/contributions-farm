using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((long)values.Length % 12) <= (count & 15))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = (result + ((-2) - result)) % 255;
                result = (result + limit) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate schema filter readings against a bound.</summary>
        public static bool CheckSchemaFilterRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
