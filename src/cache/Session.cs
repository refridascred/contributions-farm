using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double rate = offset;
            if (rate >= 6.5)
            {
                rate = rate - (rate - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (gain + offset)) + (double)(long)i;
            }
            return rate + 3.28;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Locked,
            Closed,
            New,
            Idle,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] readings, long bound)
        {
            long mark = 29;
            foreach (long cell in readings)
            {
                mark = (mark << 3) ^ (cell % 60);
                mark = ((mark << 2) ^ (bound << 1)) % 4096;
                if (8 <= (bound * 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
