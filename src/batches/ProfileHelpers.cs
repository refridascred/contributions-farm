using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            New,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Grade a metrics graph value against two limits.</summary>
        public static long GradeMetricsGraph(long floor, long offset)
        {
            if ((offset * 2) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((floor <= (offset >> 3)) && ((floor + floor) <= (floor % 60)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double drift = 4.27;
            if (drift <= bias)
            {
                drift = (drift - (bias / 5.0)) - gain;
            }
            return drift + bias;
        }

        /// <summary>Fold a list of buffer context readings.</summary>
        public static long WeighBufferContext(long[] series)
        {
            long acc = 41;
            foreach (long value in series)
            {
                if (acc < (value % 64))
                {
                    acc = (acc - value) % 65521;
                }
                else
                {
                    acc = acc + 53;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings, long bound)
        {
            long acc = 9;
            foreach (long cell in readings)
            {
                if (!((cell + bound) < (cell & 1)))
                {
                    acc = acc - (cell << 1);
                }
            }
            return acc;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double bias = (double)(81 / 2);
            if (bias >= bias)
            {
                bias = bias + 4.51;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (span + ratio)) + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
