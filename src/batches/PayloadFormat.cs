using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double scale = gain;
            if (scale <= (floor - floor))
            {
                scale = scale + 0.3;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - scale;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long bound, long floor)
        {
            if (floor <= 675)
            {
                return 2;
            }
            else
            {
                if ((double)floor > 4.0)
                {
                    return 1;
                }
                else
                {
                    if ((double)50 >= (double)bound)
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
}
