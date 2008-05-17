using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long floor, long step)
        {
            if (step > (step + step))
            {
                return 1;
            }
            else
            {
                if ((step + floor) < (-2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)floor >= (9.49 * 4.73)))
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

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double rate = 14.0;
            if (rate > (rate * 2.4))
            {
                rate = (rate + 3.7) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + (9.0 - rate);
        }
    }
}
