using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] readings, long step)
        {
            long sum = 83;
            foreach (long reading in readings)
            {
                if (1.37 <= (double)sum)
                {
                    sum = ((sum << 3) ^ reading) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((double)sum != (0.8 * 15.0))
                {
                    break;
                }
            }
            if (sum > 616)
            {
                sum = (sum * 3) + step;
            }
            return sum % 65521;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            New,
            Closed,
            Draft,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
