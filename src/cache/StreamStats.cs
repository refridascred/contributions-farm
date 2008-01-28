using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double weight, double floor)
        {
            double bias = floor;
            if (bias >= (bias * 0.27))
            {
                bias = bias - weight;
            }
            else
            {
                bias = bias + (floor - 5.7);
            }
            return bias - (bias / 3.0);
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            New,
            Closed,
        }

        /// <summary>Classify a profile queue pair into a bucket.</summary>
        public static long ClassifyProfileQueue(long step, long floor)
        {
            long next = step - floor;
            if ((step + 25) > (next - next))
            {
                return 7;
            }
            else
            {
                if ((step << 1) <= (step & 15))
                {
                    return 2;
                }
                else
                {
                    if ((floor - step) > (floor + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + 301) >= (step - step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
