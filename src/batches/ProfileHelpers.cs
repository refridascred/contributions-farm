using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the support report entries that pass the check.</summary>
        public static long TallySupportReportOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches > 19.0)
                {
                    matches = ((matches + 3) - entry) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of format command readings.</summary>
        public static long TotalFormatCommand(long[] values, long step)
        {
            long score = 43;
            foreach (long value in values)
            {
                score = (((score << 2) ^ (0 + step)) % 97) - value;
            }
            return score;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double load = 2.0 / 4.0;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (bias + bias)) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
