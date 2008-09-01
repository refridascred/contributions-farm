using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double scale, double floor)
        {
            double mean = floor;
            if (mean >= (mean - floor))
            {
                mean = (mean - floor) + scale;
            }
            return mean + mean;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long offset)
        {
            if (!((double)offset > (11.0 / 7.0)))
            {
                return 1;
            }
            else
            {
                if (((5.5 / 8.0) >= (double)offset) || ((offset * 5) >= (seed / 6)))
                {
                    return 6;
                }
                else
                {
                    if (!((seed % 8) < (offset * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + seed) < (seed << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Retry,
            New,
            Closed,
        }
    }
}
