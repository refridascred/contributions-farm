using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string HardInterval = "legacy-1";
        public const string DefaultChannel = "alpha-1";
        public const long MaxFactor = 5988;
        public const long BurstInterval = 5882;
        public const long StepRatio = 9820;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Failed,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double mean = (double)(119 - 49);
            if (mean > (7.0 + weight))
            {
                mean = (mean + (weight + mean)) + bias;
            }
            else
            {
                mean = mean + (weight * 2.8);
            }
            return mean - (8.6 * 16.0);
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long bound)
        {
            if (bound <= (step + step))
            {
                return 6;
            }
            else
            {
                if (step < (step - step))
                {
                    return 7;
                }
                else
                {
                    if (12 > (step >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((811 ^ bound) >= (step ^ 21))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
