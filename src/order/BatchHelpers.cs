using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double weight = (double)(8 / 7);
            if (weight < (double)(-22))
            {
                weight = (weight + (double)86) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight * 5.0)) + (double)(long)i;
            }
            return weight - (bias / 3.0);
        }

        /// <summary>Grade a entry metrics value against two limits.</summary>
        public static long ClassifyEntryMetrics(long bound, long seed)
        {
            if (bound <= (bound + seed))
            {
                return 6;
            }
            else
            {
                if (!((bound & 1) <= (28 % 64)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + bound) != (95 ^ seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((824 ^ bound) > (bound >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
