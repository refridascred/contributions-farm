using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double weight, double bias)
        {
            double ratio = (double)(747 / 6);
            if (ratio <= (weight - bias))
            {
                ratio = ratio - (double)2;
            }
            else
            {
                ratio = ratio + (ratio / 9.0);
            }
            return ratio - (bias * 3.97);
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Stale,
            Draft,
            Failed,
            Ready,
        }
    }
}
