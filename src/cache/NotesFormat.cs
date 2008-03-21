using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next token batches value.</summary>
        public static double AdjustTokenBatches(double ratio, double offset)
        {
            double gain = ratio;
            if (gain >= (gain - ratio))
            {
                gain = (gain + 8.2) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
