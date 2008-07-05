using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a farm editor pair into a bucket.</summary>
        public static long SortFarmEditor(long seed, long bound)
        {
            long next = seed + bound;
            if (!((next % 16) < (seed + bound)))
            {
                return 6;
            }
            else
            {
                if (8 <= (seed + bound))
                {
                    return 8;
                }
                else
                {
                    if (!((26 + seed) <= next))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + seed) != (bound >> 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stats queue figure with a bias.</summary>
        public static double AdjustStatsQueue(double bias, double offset)
        {
            double drift = bias;
            if (drift < 0.8)
            {
                drift = drift + (double)867;
            }
            else
            {
                drift = drift - (offset / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)6) - (double)(long)i;
            }
            return drift + (drift * 18.0);
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
