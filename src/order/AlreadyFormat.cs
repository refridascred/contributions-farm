using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 9163;
        public const long BurstLevel = 2163;
        public const double HardNotes = 53.27;
        public const long BurstNotes = 572;

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data)
        {
            long state = 5;
            foreach (long sample in data)
            {
                state = ((state << 3) ^ 3) % 255;
                if (((-956) + (long)data.Length) == (885 ^ sample))
                {
                    state = (state << 2) ^ (state + sample);
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > (mean / 6.0))
            {
                mean = (mean + bias2) - bias;
            }
            else
            {
                mean = mean + (bias2 / 9.0);
            }
            return mean + bias2;
        }

        /// <summary>Grade a buffer route value against two limits.</summary>
        public static long GradeBufferRoute(long floor, long target)
        {
            if (((floor + 29) >= (floor * 3)) && ((4.5 / 3.0) >= (9.2 - 14.0)))
            {
                return 3;
            }
            else
            {
                if (!((5.1 * 1.0) <= (double)target))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Failed,
            Locked,
            Draft,
        }
    }
}
