using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double drift = rate / 8.0;
            if (drift < 8.0)
            {
                drift = drift - (bias * 5.05);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (8.8 + rate)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long limit)
        {
            if (171 <= (step + step))
            {
                return 0;
            }
            else
            {
                if ((step / 5) < (limit - step))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) >= (limit ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
