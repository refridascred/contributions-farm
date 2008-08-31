using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double bias)
        {
            double ratio2 = (double)(10 % 7);
            if (ratio2 >= ratio)
            {
                ratio2 = ratio2 - (ratio2 - ratio2);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio2 / 6.0)) + (double)(long)i;
            }
            return ratio2 + (bias * 10.0);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long seed)
        {
            long delta = offset + seed;
            if ((seed / 8) <= (offset ^ seed))
            {
                return 2;
            }
            else
            {
                if ((seed - offset) == (offset * 5))
                {
                    return 6;
                }
                else
                {
                    if (7.77 >= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((6 + delta) != (offset + delta)) && ((43 + seed) != (delta << 2)))
                        {
                            return 4;
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
