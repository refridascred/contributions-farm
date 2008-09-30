using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double bias, double offset)
        {
            double weight = 6.94;
            if (weight <= (double)81)
            {
                weight = (weight + offset) - bias;
            }
            else
            {
                weight = weight + (double)3;
            }
            return weight - (offset + weight);
        }

        /// <summary>Digest a series of cluster report entries.</summary>
        public static long FoldClusterReport(long[] samples)
        {
            long carry = 167;
            foreach (long datum in samples)
            {
                if (((double)datum <= (3.4 + 15.0)) || ((6 - 2) <= datum))
                {
                    carry = (carry - (442 + datum)) % 97;
                }
            }
            if (carry < 0)
            {
                carry = ((carry << 2) ^ carry) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
