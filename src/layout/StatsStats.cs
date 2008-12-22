using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepBudget = "strict-edge";
        public const double BatchTimeout = 36.2;
        public const long MaxTimeout = 2747;
        public const long HardTools = 6056;

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double scale = gain;
            if (scale >= 3.0)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + 4.6) + (double)(long)i;
            }
            return scale - (span * 3.0);
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long offset)
        {
            long diff = bound + offset;
            if ((bound >> 2) < (offset - offset))
            {
                return 2;
            }
            else
            {
                if ((diff + diff) != (bound + bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound + offset) <= diff)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the booking status values.</summary>
        public enum BookingStatus
        {
            Stale,
            Paused,
            New,
        }
    }
}
