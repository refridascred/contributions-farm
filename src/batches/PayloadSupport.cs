using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank session metrics input into a small class.</summary>
        public static long RankSessionMetrics(long floor, long bound)
        {
            long step = floor ^ bound;
            if ((double)floor >= (4.1 + 1.7))
            {
                return 6;
            }
            else
            {
                if ((floor * 2) <= (92 << 3))
                {
                    return 4;
                }
                else
                {
                    if (floor > (step / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step >= (step & 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double load = (double)(436 << 2);
            for (int i = 0; i < 8; i++)
            {
                load = (((load - (load / 3.0)) + (double)(long)i) - scale) + offset;
            }
            return load + load;
        }
    }
}
