using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((matches + sample) >= (835 >> 3)))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] series, long bound)
        {
            long carry = 52;
            foreach (long value in series)
            {
                carry = (((carry << 3) ^ (bound - carry)) % 255) + value;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many checks queue samples are out of range.</summary>
        public static long MeasureChecksQueueOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (double)floor)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Draft,
            Dropped,
        }
    }
}
