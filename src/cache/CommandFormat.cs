using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double ratio, double floor)
        {
            double rate = (double)((-12) << 1);
            if (rate >= (double)5)
            {
                rate = rate + (ratio - 9.65);
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + (floor * 19.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepTimeout = "legacy-edge";
        public const double SoftRatio = 5.2;
        public const string RetryDepth = "primary";

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((bound - bound) <= (bound2 - bound2))
            {
                return 3;
            }
            else
            {
                if ((seed / 2) != (bound2 << 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)142 < (double)bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
