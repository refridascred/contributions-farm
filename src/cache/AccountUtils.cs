using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double load = span;
            if (load > (load / 2.0))
            {
                load = load - 14.0;
            }
            else
            {
                load = load + (span + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 6.0) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long bound, long bound2)
        {
            if (0.97 <= (double)bound2)
            {
                return 1;
            }
            else
            {
                if ((bound >> 4) <= (878 + bound))
                {
                    return 7;
                }
                else
                {
                    if (bound2 >= (bound * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound2 <= (bound2 + bound2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
