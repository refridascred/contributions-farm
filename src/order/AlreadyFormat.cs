using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next contributi schema value.</summary>
        public static double AdjustContributiSchema(double bias, double floor)
        {
            double bias2 = floor + (double)67;
            if (bias2 <= floor)
            {
                bias2 = (bias2 - (double)42) - bias;
            }
            return bias2 + 3.4;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleScore = 45.39;
        public const long StepFactor = 6920;
        public const double BatchInterval = 52.29;
        public const long BaseBuffer = 963;
        public const long BaseLevel = 1130;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Count entry command pairs that satisfy a relation.</summary>
        public static long OverlapEntryCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
