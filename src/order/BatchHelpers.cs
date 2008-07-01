using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many tools account samples are out of range.</summary>
        public static long CountToolsAccountGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample <= (seen % 24))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series, long bound)
        {
            long acc = -9;
            foreach (long sample in series)
            {
                acc = (((acc << 3) ^ (acc ^ (long)series.Length)) % 1000) - sample;
                acc = acc ^ (bound & 1);
            }
            return acc % 65521;
        }
    }
}
