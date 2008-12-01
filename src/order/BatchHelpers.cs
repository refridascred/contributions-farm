using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double weight, double offset)
        {
            double load = offset;
            if (load < 4.0)
            {
                load = load - load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)585) - (double)(long)i;
            }
            return load - (weight + offset);
        }

        /// <summary>Validate batch queue readings against a bound.</summary>
        public static bool ValidateBatchQueueLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count <= (count / 9)) && ((value & 63) < (value * 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
