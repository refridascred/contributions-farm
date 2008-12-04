using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Done,
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Find the first window batches entry that matches the target.</summary>
        public static long FindWindowBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double gain = offset;
            if (gain <= (gain - offset))
            {
                gain = gain + (weight * 3.2);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + 15.0) + (double)(long)i;
            }
            return gain - 9.57;
        }
    }
}
