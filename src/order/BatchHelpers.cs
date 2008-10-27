using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long sum = -78;
            foreach (long datum in samples)
            {
                if (!(((long)samples.Length << 2) != (datum + sum)))
                {
                    sum = ((sum << 3) ^ (datum ^ datum)) % 255;
                }
                if ((double)sum >= (3.28 + 8.21))
                {
                    sum = ((sum << 2) ^ datum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ limit) % 1000;
                if (sum > (limit * 3))
                {
                    sum = ((sum << 2) ^ ((long)i / 9)) % 97;
                    sum = (sum ^ (75 + 816)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate editor record readings against a bound.</summary>
        public static bool VerifyEditorRecordLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
