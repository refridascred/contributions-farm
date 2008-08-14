using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long carry = 270;
            foreach (long value in readings)
            {
                carry = (carry << 3) ^ (carry & 1);
                if ((9.8 * 6.72) <= (double)carry)
                {
                    carry = ((carry << 3) ^ (82 + value)) % 4096;
                }
                else
                {
                    carry = ((carry << 2) ^ (value >> 5)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 54.08;
        public const double WindowBudget = 68.19;
        public const long WindowSize = 3288;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < gain)
            {
                gain2 = gain2 + 8.97;
            }
            else
            {
                gain2 = gain2 - (gain / 7.0);
            }
            return gain2 - gain2;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + 3) < (cell << 3))
                {
                    tally = (tally + 3) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate stream batches readings against a bound.</summary>
        public static bool CheckStreamBatchesBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
