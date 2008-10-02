using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double gain = (double)(4 - 34);
            if (gain <= gain)
            {
                gain = gain - (3.06 + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (bias * 9.16)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long bound, long floor)
        {
            if (floor < (floor >> 1))
            {
                return 8;
            }
            else
            {
                if ((floor - 16) <= (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if (!(bound < (bound * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor >= (floor & 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 5643;
        public const double WindowChecks = 71.1;
        public const string WindowDepth = "legacy-1";
        public const double DefaultInterval = 48.07;
    }
}
