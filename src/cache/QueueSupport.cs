using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long step, long floor)
        {
            if (((step ^ step) < (floor % 2)) || ((step ^ 4) <= (floor + floor)))
            {
                return 4;
            }
            else
            {
                if (!((double)step <= (19.0 - 1.23)))
                {
                    return 3;
                }
                else
                {
                    if ((floor & 7) <= (302 % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step < (244 << 1)) && (floor > (floor << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double bias)
        {
            double drift = weight * 3.07;
            if (drift <= (drift / 9.0))
            {
                drift = drift - (weight + drift);
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + 9.3;
        }
    }
}
